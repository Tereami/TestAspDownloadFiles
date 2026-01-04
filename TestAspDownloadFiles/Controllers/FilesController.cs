using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TestAspDownloadFiles.Models;


namespace TestAspDownloadFiles.Controllers
{
    [ApiController]
    [Route("api/files")]
    public class FilesController : Controller
    {
        private readonly string _filesFolder = string.Empty;

        public FilesController(IWebHostEnvironment env)
        {
            string rootFolder = env.ContentRootPath;
            _filesFolder = Path.Combine(rootFolder, "Files");
        }

        [HttpGet("list")]
        public ActionResult List()
        {
            if (!Directory.Exists(_filesFolder))
                return NotFound($"No folder: {_filesFolder}");

            List<string> files = Directory.GetFiles(_filesFolder)
                .Select(i => Path.GetFileName(i))
                .ToList();

            return Json(files);
        }

        [HttpGet("download/{fileName}")]
        public ActionResult Download(string filename)
        {
            if (filename.Contains(".."))
                return BadRequest();

            if (string.IsNullOrEmpty(filename))
                return BadRequest("Filename is not set");

            string fullFilePath = Path.Combine(_filesFolder, filename);

            if (!System.IO.File.Exists(fullFilePath))
                return NotFound();

            FileStream stream = new FileStream(
                fullFilePath,
                FileMode.Open,
                FileAccess.Read,
                FileShare.Read);

            return File(
                stream,
                "application/octet-stream",
                filename,
                true);
        }

        [HttpPost("upload")]
        public async Task<IActionResult> Upload(IFormFile uploadedFile, [FromForm] string checksum)
        {
            if (uploadedFile == null || uploadedFile.Length == 0)
                return BadRequest(new UploadResultDto(false, "No file"));

            string tempFilesFolder = Path.Combine(_filesFolder, "Temp"); //Path.GetTempFileName();
            if (!Directory.Exists(tempFilesFolder))
                Directory.CreateDirectory(tempFilesFolder);
            string tempFilePath = Path.Combine(tempFilesFolder, uploadedFile.FileName);

            try
            {
                await using (FileStream fs = new FileStream(tempFilePath, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fs);
                }

                string calculatedHashSum = await ChecksumCalculator.GetSha256(tempFilePath);
                bool hashsumCheck = calculatedHashSum.Equals(checksum, StringComparison.OrdinalIgnoreCase);
                if (!hashsumCheck)
                    return BadRequest(new UploadResultDto(false, "Incorrect checksum"));

                string destFilePath = Path.Combine(_filesFolder, uploadedFile.FileName);

                if (System.IO.File.Exists(destFilePath))
                    destFilePath = Path.Combine(destFilePath + DateTime.Now.ToString("yyyy-MM-dd_HHmmss"));

                System.IO.File.Move(tempFilePath, destFilePath);

                return Ok(new UploadResultDto(true));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new UploadResultDto(false, ex.Message));
            }
            finally
            {
                if (System.IO.File.Exists(tempFilePath))
                    System.IO.File.Delete(tempFilePath);
            }
        }
    }
}
