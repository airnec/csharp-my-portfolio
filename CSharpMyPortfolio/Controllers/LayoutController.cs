using Microsoft.AspNetCore.Mvc;

namespace CSharpMyPortfolio.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
