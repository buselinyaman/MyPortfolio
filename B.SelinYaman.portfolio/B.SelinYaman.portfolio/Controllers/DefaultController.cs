using Microsoft.AspNetCore.Mvc;

namespace B.SelinYaman.portfolio.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
