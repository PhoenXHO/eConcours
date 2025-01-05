using Microsoft.AspNetCore.Mvc;

namespace eConcours.Controllers
{
    public class LandingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
