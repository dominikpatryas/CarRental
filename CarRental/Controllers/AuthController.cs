using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRental.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    [Route("[controller]")]
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("register")]
        public IActionResult RegisterLoginProcess()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register([FromBody]User user)
        {
            if (user.Username != null)
            {
                return View("Index");
            }
            else
            {
                return View("RegisterLoginProcess");
            }
        }

        [HttpPost]
        public IActionResult Login([FromForm]User user)
        {
            return View("RegisterLoginProcess");
        }



    }
}