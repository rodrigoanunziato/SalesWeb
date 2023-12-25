using Microsoft.AspNetCore.Mvc;
using SalesWeb.Models;
using System.Collections.Generic;

namespace SalesWeb.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Departments> list = new List<Departments>();
            list.Add(new Departments { Id = 1, Name = "Eletronics" });
            list.Add(new Departments { Id = 2, Name = "Fashion" });
            
            return View(list);
        }
    }
}
