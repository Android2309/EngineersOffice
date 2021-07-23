using EngineersOffice_Site.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace EngineersOffice_Site.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public FileResult GetFile_dogovor() => File(@"~/Files/dogovor.pdf", "Application/pdf", "dogovor.pdf");
        public FileResult GetFile_partner() => File(@"~/Files/partner.pdf", "Application/pdf", "partner.pdf");
        public FileResult GetFile_privacy() => File(@"~/Files/privacy-policy.pdf", "Application/pdf", "privacy-policy.pdf");
    }
}
