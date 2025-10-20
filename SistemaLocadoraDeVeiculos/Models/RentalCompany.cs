using SistemaLocadoraDeVeiculos.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraDeVeiculos.Models
{
    public class RentalCompany
    {
        public List<Vehicle> Vehicles = new List<Vehicle>();
        public List<Person> Customers = new List<Person>();
        public List<Rental> Rentals = new List<Rental>();
    }
}
