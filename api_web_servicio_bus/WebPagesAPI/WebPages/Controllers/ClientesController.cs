using Microsoft.AspNetCore.Mvc;

namespace WebPages.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Index()
        {
            var url = "";
            return View();
        }
    }
}
