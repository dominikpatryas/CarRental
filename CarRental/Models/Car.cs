using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Engine { get; set; }
        public int HorsePower { get; set; }
        public string Gear { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public int Acceleration { get; set; }
        public int UserId { get; set; }
        public string MessageRent { get; set; }
        public DateTime Rent { get; set; }
        public DateTime EndRent { get; set; }
        public bool isRent { get; set; }
        public ICollection<Photo> Photos { get; set; }

        public Car(int id, string brand, string model, int year, int horsePower)
        {
            Id = id;
            Brand = brand;
            Model = model;
            Year = year;
            HorsePower = horsePower;
        }
    }
}
