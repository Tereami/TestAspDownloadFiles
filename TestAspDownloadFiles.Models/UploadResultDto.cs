namespace TestAspDownloadFiles.Models
{
    public class UploadResultDto
    {
        public bool Success { get; set; }

        public string? Message { get; set; }

        public UploadResultDto(bool success, string message = "")
        {
            Success = success;
            Message = message;
        }
    }
}
