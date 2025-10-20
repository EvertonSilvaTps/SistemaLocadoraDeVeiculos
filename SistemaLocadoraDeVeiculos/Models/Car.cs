using SistemaLocadoraDeVeiculos.Abstracts;
using SistemaLocadoraDeVeiculos.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraDeVeiculos.Models
{
    public class Car : Vehicle
    {
        private bool ManualGearbox {  get; set; }
        private int NumberOfPassengers { get; set; }

        public Car(string model, string brand, string licensePlate, Kind kind, string color, int year, bool isAvailable, double daryCost, bool gearbox, int passengers) 
            : base(model, brand, licensePlate, kind, color, year, isAvailable, daryCost)
        {
            this.ManualGearbox = gearbox;
            this.NumberOfPassengers = passengers;
        }
    }
}
