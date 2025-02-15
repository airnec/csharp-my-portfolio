using Microsoft.AspNetCore.Mvc;

namespace CSharpMyPortfolio.ViewComponents
{
    public class _HeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
