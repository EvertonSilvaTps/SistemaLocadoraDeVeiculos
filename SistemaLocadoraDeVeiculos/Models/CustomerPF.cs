using SistemaLocadoraDeVeiculos.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraDeVeiculos.Models
{
    public class CustomerPF : Person
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string CNH { get; set; }
        public string CPF { get; set; }

        public CustomerPF(
            string name,
            DateOnly birthDate,
            Contact contact,
            Address address,
            string cnh,
            string cpf
            )
            : base(name, birthDate, contact, address)   // Comparação com os parâmetros
        {
            this.CNH = cnh;
            this.CPF = cpf;
        }

        public override string ToString()
        {
            return $"{this.Id}\n{base.ToString()} \nCNH: {this.CNH} \nCPF: {this.CPF}";
        }

    }
}
