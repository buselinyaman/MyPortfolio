using Microsoft.AspNetCore.Mvc;

namespace B.SelinYaman.portfolio.ViewComponents
{
    public class _NavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();

        }
    }
}
