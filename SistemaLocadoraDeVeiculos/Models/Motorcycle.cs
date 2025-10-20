using SistemaLocadoraDeVeiculos.Abstracts;
using SistemaLocadoraDeVeiculos.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraDeVeiculos.Models
{
    public class Motorcycle : Vehicle
    {
        private int EngineCapacity { get; set; }
        private int NumberOfPassengers { get; set; }
        public Motorcycle(string model, string brand, string licensePlate, Kind kind, string color, int year, bool isAvailable, double daryCost, int engine, int passengers) 
            : base(model, brand, licensePlate, kind, color, year, isAvailable, daryCost)
        {
            this.EngineCapacity = engine;
            this.NumberOfPassengers = passengers;
        }
    }
}
