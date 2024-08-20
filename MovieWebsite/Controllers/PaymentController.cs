using Microsoft.AspNetCore.Mvc;

namespace MovieWebsite.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
