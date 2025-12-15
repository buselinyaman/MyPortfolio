using B.SelinYaman.portfolio.DAL.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace B.SelinYaman.portfolio.ViewComponents
{
    public class _HeadComponentPartial:ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
