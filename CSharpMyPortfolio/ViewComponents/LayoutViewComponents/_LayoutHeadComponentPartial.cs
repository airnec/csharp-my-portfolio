using Microsoft.AspNetCore.Mvc;

namespace CSharpMyPortfolio.ViewComponents.LayoutViewComponents
{
	public class _LayoutHeadComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
