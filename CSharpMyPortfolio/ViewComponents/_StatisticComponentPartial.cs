using Microsoft.AspNetCore.Mvc;

namespace CSharpMyPortfolio.ViewComponents
{
    public class _StatisticComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
