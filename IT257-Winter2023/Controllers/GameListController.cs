using Microsoft.AspNetCore.Mvc;

namespace IT257_Winter2023.Controllers
{
    public class GameListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
