using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace TestAspDownloadFiles.Controllers
{
    [ApiController]
    [Route("files")]
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
    }
}
