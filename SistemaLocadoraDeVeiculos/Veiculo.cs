using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraDeVeiculos
{
    public abstract class Veiculo
    {
        private int qtddDias {  get; set; }
        private double valorDiaria { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Cor {  get; set; }
        public string Placa { get; set; }



        public Veiculo(string tipo, string marca, string cor, string placa)
        {



        }


        public override string ToString()
        {
            return ($"Tipo: {this.Tipo}" +
                $"Modelo: {this.Marca}" +
                $"Cor: {this.Cor}" +
                $"Placa: {this.Placa}");
        }





    }
}
