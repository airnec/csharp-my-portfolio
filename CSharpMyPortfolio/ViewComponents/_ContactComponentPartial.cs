using Microsoft.AspNetCore.Mvc;

namespace CSharpMyPortfolio.ViewComponents
{
    public class _ContactComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
