using Microsoft.AspNetCore.Mvc;

namespace EngineersOffice_Site.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
