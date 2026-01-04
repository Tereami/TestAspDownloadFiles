using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;

namespace TestAspDownloadFiles.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult Index(int statusCode)
        {
            string reason = ReasonPhrases.GetReasonPhrase(statusCode);

            return View((statusCode, reason));
        }
    }
}
