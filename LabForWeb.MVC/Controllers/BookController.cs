using Microsoft.AspNetCore.Mvc;

namespace LabForWeb.MVC.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
