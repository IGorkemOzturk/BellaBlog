using BellaBlog.Models;
using BellaBlog.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BellaBlog.Controllers
{
    public class HomeController : Controller
    {
        BlogRepository br = new BlogRepository();
        AdminRepository ar = new AdminRepository();
        Context c = new Context();
        public IActionResult Index(int id)
        {
            
            return View(br.TList("Admin"));
        }
        public IActionResult BlogDetay(int id)
        {
            var detay = c.Blogs.Where(x =>  x.BlogId==id).ToList();
            return View(detay);
        }
    }
}
