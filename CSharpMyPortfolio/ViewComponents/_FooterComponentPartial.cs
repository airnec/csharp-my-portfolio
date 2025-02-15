using Microsoft.AspNetCore.Mvc;

namespace CSharpMyPortfolio.ViewComponents
{
    public class _FooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
