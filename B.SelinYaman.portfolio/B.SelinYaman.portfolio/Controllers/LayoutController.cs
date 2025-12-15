using Microsoft.AspNetCore.Mvc;

namespace B.SelinYaman.portfolio.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
