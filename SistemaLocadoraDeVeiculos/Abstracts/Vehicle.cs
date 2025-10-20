using SistemaLocadoraDeVeiculos.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraDeVeiculos.Abstracts
{
    public abstract class Vehicle
    {

        private Guid Id { get; set; } = Guid.NewGuid();
        private string Model {  get; set; }
        private string Brand { get; set; }
        private string LicensePlate {  get; set; }
        private Kind Kind { get; set; }
        private string Color { get; set; }
        private int Year { get; set; }
        private bool IsAvailable { get; set; } = true;
        private double DaryCost { get; set; }

        protected Vehicle(string model, string brand, string licensePlate, 
            Kind kind, string color, int year, bool isAvailable, double daryCost)
        {
            Model = model;
            Brand = brand;
            LicensePlate = licensePlate;
            Kind = kind;
            Color = color;
            Year = year;
            IsAvailable = isAvailable;
            DaryCost = daryCost;
        }
    }
}
