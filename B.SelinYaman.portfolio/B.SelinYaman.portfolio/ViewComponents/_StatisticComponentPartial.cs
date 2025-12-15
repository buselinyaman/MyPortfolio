using Microsoft.AspNetCore.Mvc;

namespace B.SelinYaman.portfolio.ViewComponents
{
    public class _StatisticComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
