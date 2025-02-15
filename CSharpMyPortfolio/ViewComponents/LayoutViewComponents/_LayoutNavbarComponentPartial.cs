using Microsoft.AspNetCore.Mvc;
using CSharpMyPortfolio.DAL.Context;

namespace CSharpMyPortfolio.ViewComponents.LayoutViewComponents
{
	public class _LayoutNavbarComponentPartial:ViewComponent
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IViewComponentResult Invoke()
		{
			ViewBag.toDoListCount = context.ToDoLists.Where(x => x.Status == false).Count();
			var values = context.ToDoLists.Where(x => x.Status == false).ToList();
			return View(values);
		}
	}
}
