using B.SelinYaman.portfolio.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace B.SelinYaman.portfolio.ViewComponents
{
    public class _AboutComponentPartial:ViewComponent
    {
        private readonly MyPortfolioContext _portfolioContext;

        public _AboutComponentPartial(MyPortfolioContext portfolioContext)
        {
            _portfolioContext = portfolioContext;
        }
        public IViewComponentResult Invoke()
        {
            var values = _portfolioContext.Abouts.ToList();
            return View(values); 
        }

    }
}

