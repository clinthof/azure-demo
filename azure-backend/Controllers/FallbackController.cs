using System.IO;
using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;

namespace azure_backend.Controllers
{
  public class FallbackController : Controller
  {
    public IActionResult Index()
    {
      return PhysicalFilePath(Path.Combine(
        Directory.GetCurrentDirectory(), "wwwroot", "index.html"
        ),
        MediaTypeNames.Text.Html);
    }
  }
}