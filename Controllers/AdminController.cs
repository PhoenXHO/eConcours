using Microsoft.AspNetCore.Mvc;

namespace eConcours.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
