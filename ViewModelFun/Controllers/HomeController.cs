using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
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
            Message newMessage = new Message()
            {
                ThisMessage = "This is a message in a string"
            };
            return View(newMessage);
        }
        public IActionResult Numbers()
        {
            int[] Numbaz = new int[] {1,2,3,4,5};
            Numz TheseNumbers = new Numz()
            {
                Numberz = Numbaz
            };
            return View(TheseNumbers);
        }
        public IActionResult Users()
        {
            Person ThisPerson = new Person()
            {
                FirstName = "Mark",
                LastName = "Edwards"
            };
            Person ThatPerson = new Person()
            {
                FirstName = "Rob",
                LastName = "Yearling"
            };
            Person NotThisPerson = new Person()
            {
                FirstName = "Nathan",
                LastName = "Bell"
            };
            Person SeriouslyThisPerson = new Person()
            {
                FirstName = "Adrien",
                LastName = "Dion"
            };
            List<Person> TheseGuys = new List<Person>()
            {
                ThisPerson,
                ThatPerson,
                NotThisPerson,
                SeriouslyThisPerson
            };
            return View(TheseGuys);
        }
        public IActionResult Person()
        {
            return View();
        }

        public IActionResult Privacy()
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
