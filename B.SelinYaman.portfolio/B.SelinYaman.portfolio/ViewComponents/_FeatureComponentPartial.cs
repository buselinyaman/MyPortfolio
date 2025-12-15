using B.SelinYaman.portfolio.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace B.SelinYaman.portfolio.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        private readonly MyPortfolioContext _portfolioContext;

        public _FeatureComponentPartial(MyPortfolioContext portfolioContext)
        {
            _portfolioContext = portfolioContext;
        }

        public IViewComponentResult Invoke()
        {
            //Console.WriteLine("FEATURE COMPONENT ÇALIŞTI!");
            var values = _portfolioContext.Features.ToList();
            return View(values);
        }
    }
}
