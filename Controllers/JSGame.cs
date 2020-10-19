using Microsoft.AspNetCore.Mvc;

namespace KeneilPortfolio.Controllers
{
    public class JSGame : Controller
    {
        public IActionResult Game()
        {
            return View();
        }
    }
}
