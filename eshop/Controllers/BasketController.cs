﻿using Microsoft.AspNetCore.Mvc;

namespace eshop.Controllers
{
    public class BasketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
