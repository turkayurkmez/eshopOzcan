
using eshop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace eshop.ViewComponents
{
    public class HeroMenuViewComponent : ViewComponent
    {
        List<Category> categories;

        public HeroMenuViewComponent()
        {
            categories = new List<Category>
            {
                new Category { Id = 1, Name = "Bilgisayar" },
                new Category { Id = 2, Name = "Ses sistemleri" },
                new Category { Id = 3, Name = "Mobilya" },
                new Category { Id = 4, Name = "Kitap" },
                new Category { Id = 5, Name = "Tekstil" }
            };
        }
        



        public IViewComponentResult Invoke()
        {
            return View(categories);
        }
    }
}
