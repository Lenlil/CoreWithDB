using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWithDB.Data;
using Microsoft.AspNetCore.Mvc;
using CoreWithDB.Models;

namespace CoreWithDB.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDBContext _context;

        public HomeController(ApplicationDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model = _context.Employees.ToList();
            return View(model);
        }      
    }
}
