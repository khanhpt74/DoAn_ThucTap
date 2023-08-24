using DoAn_ThucTap.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DoAn_ThucTap.Controllers
{
    public class HomeController : Controller
    {
    
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
             //chuyen huong qua action khac controller
            //return RedirectToAction("ThuVienSach","Book");
            //var model = new Book
            //{
                //Id = 1,
                //Name = "khanh",
                //Authors = "kim dong",
                //Publisher = "kim dong",
                //Year = 2023,
                //Description = "Dsfhaf",
                //DataFile ="sgsajhs",

            //};

            //Console.WriteLine(model.Name);
           // Console.WriteLine(model.Authors);

            return View();
        }

        public IActionResult TrangChu()
        {
            return View();
            //return RedirectToAction("ThuVienSach", "Book"); 
        }
        public IActionResult GioiThieu()
        {
            //chuyen huong qua action khac, cung controller 
            //return RedirectToAction("DangNhap");
            return View();
            
        }

        public IActionResult DangNhap()
        {
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}