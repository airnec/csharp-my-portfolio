using Microsoft.AspNetCore.Mvc;
using CSharpMyPortfolio.DAL.Context;

namespace CSharpMyPortfolio.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Skills.ToList();
            return View(values);
        }
    }
}
