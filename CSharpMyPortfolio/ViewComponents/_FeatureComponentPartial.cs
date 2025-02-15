using Microsoft.AspNetCore.Mvc;
using CSharpMyPortfolio.DAL.Context;

namespace CSharpMyPortfolio.ViewComponents
{
    public class _FeatureComponentPartial:ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Features.ToList();
            return View(values);
        }
    }
}
