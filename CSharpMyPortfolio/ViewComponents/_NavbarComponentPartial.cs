using Microsoft.AspNetCore.Mvc;

namespace CSharpMyPortfolio.ViewComponents
{
    public class _NavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
