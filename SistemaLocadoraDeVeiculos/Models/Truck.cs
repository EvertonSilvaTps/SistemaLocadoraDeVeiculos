using SistemaLocadoraDeVeiculos.Abstracts;
using SistemaLocadoraDeVeiculos.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraDeVeiculos.Models
{
    public class Truck : Vehicle
    {
        private int LoadCapacity { get; set; }
        private int Axles { get; set; }

        public Truck(string model, string brand, string licensePlate, Kind kind, string color, int year, bool isAvailable, double daryCost, int loadCapacity, int axles) 
            : base(model, brand, licensePlate, kind, color, year, isAvailable, daryCost)
        {
            this.LoadCapacity = loadCapacity;
            this.Axles = axles;
        }
    }
}
