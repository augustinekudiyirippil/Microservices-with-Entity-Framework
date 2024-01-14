using Microsoft.AspNetCore.Mvc;

namespace CustomerWebApi.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
