using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRental.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    public class CarsController : Controller
    {
        public async Task<IActionResult> Index()
        {
            //return View(await _context.Employees.ToArrayAsync());
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Car(int id)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Cars()
        {
            return View();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> RentCar(int id, Car car)
        {
            return View();
        }
    }
}