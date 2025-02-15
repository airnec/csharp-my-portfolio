using Microsoft.AspNetCore.Mvc;
using CSharpMyPortfolio.DAL.Context;

namespace CSharpMyPortfolio.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }
    }
}
