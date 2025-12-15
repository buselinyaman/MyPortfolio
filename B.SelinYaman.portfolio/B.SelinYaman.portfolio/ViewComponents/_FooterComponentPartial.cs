using B.SelinYaman.portfolio.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace B.SelinYaman.portfolio.ViewComponents
{
    public class _FooterComponentPartial:ViewComponent
    {
        
        public IViewComponentResult Invoke() 
        {  
            return View(); 
        }
    }
}
