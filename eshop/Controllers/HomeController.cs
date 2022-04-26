using eshop.Models;
using eshop.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace eshop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int page)
        {
            var productService = new ProductService();
            var products = productService.GetProducts();

            var count = products.Count;
            var productPerPage = 4; //sayfada gösterilecek toplam ürün sayısı.
            var totalPages = Math.Ceiling((decimal)count / productPerPage);


            ViewBag.TotalPages = totalPages;

            var paginatedProducts = products.OrderBy(x => x.Id)
                                            .Skip((page - 1) * productPerPage)
                                            .Take(productPerPage)
                                            .ToList();
            /*
             * 1. sayfada 0 atla 3 al
             * 2. sayfada 3 atla 3 al,
             * 3. sayfada 6 atla 3 al
             */


            return View(paginatedProducts);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ShoppingCart()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
