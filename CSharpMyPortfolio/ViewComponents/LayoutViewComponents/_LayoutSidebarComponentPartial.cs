using Microsoft.AspNetCore.Mvc;

namespace CSharpMyPortfolio.ViewComponents.LayoutViewComponents
{
	public class _LayoutSidebarComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
