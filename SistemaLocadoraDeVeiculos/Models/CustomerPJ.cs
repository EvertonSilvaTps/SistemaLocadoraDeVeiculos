using SistemaLocadoraDeVeiculos.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraDeVeiculos.Models
{
    public class CustomerPJ : Person
    {
        private Guid Id {  get; set; } = Guid.NewGuid();
        private string CNPJ { get; set; }


        public CustomerPJ(string name, DateOnly birthDate, Contact contact, Address address, string cnpj)
            : base(name, birthDate, contact, address)
        {
            this.CNPJ = cnpj;
        }
        public override string ToString()
        {
            return $"{this.Id}\n{base.ToString()} \nCNPJ: {this.CNPJ}";
        }
    }
}
