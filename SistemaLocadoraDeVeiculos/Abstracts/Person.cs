using SistemaLocadoraDeVeiculos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraDeVeiculos.Abstracts
{
    public abstract class Person
    {
        private string Name { get; set; }
        private DateOnly BirthDate { get; set; }
        private Contact Contact { get; set; }
        private Address Address { get; set; }

        public Person(string name, DateOnly birthDate, Contact contact, Address address)
        {
            Name = name;
            BirthDate = birthDate;
            Contact = contact;
            Address = address;
        }

        public string GetName()     // Busca pelo nome
        {
            return Name;
        }

        public override string ToString()
        {
            return $"Nome: {Name}\nData de Nascimento: {BirthDate}\nContato: {Contact}\nEndereço: {Address}";
        }

        public void setContactPhone(string phone)
        {
            this.Contact.setPhone(phone);
        }

    }
}
