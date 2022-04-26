using eshop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace eshop.ViewComponents
{
    public class SliderViewComponent : ViewComponent
    {
        List<Category> categories;
        public SliderViewComponent()
        {
            categories = new List<Category>
            {
               new Category{ Id = 1, Name = "Bilgisayar", ImageUrl="img/categories/cat-1.jpg" },
               new Category{ Id = 2, Name = "Telefon", ImageUrl="img/categories/cat-2.jpg" },
               new Category{ Id = 3, Name = "Beyaz Eşya", ImageUrl="img/categories/cat-3.jpg" },
               new Category{ Id = 4, Name = "Kamera", ImageUrl="img/categories/cat-4.jpg" },
            };
        }

        public IViewComponentResult Invoke()
        {
            return View(categories);
        }
    }
}
