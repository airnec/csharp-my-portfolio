using Microsoft.AspNetCore.Mvc;

namespace CSharpMyPortfolio.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
