using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CarRental.Data;
using CarRental.Dtos;
using CarRental.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    [Route("[controller]")]
    public class CarsController : Controller
    {
        private readonly ICarRepository _repo;
        private readonly IMapper _mapper;
        public CarsController(ICarRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }

        public async Task<IActionResult> Index()
        {
            var cars = await _repo.GetCars();

            var carsToReturn = _mapper.Map<IEnumerable<CarForListsDto>>(cars);

            return View(carsToReturn);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Car(int id)
        {
            var car = await _repo.GetCar(id);

            var carToReturn = _mapper.Map<CarForDetailed>(car);

            return View(carToReturn);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> RentCar(int id, Car car)
        {
            return View();
        }

    }
}