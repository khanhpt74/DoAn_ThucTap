using Microsoft.AspNetCore.Mvc;

namespace DoAn_ThucTap.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
