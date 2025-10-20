using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SistemaLocadoraDeVeiculos
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public int idade;
        
        public int Idade
        {
            get {  return idade; }
            set
            {
                if (value >= 18)
                    idade = value;
            }
        }
    }
}
