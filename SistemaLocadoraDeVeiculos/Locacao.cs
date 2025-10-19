using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraDeVeiculos
{
    public class Locacao
    {
        private int qtddDias { get; set; }
        private double valorDiaria { get; set; }
        private double valorLocacao { get; set; }


        public Locacao(int qtddDias, double valorDiaria)
        {
            Console.WriteLine();
            
            this.valorLocacao = qtddDias * valorDiaria;

        }

        public override string ToString()
        {
            return ($"Quantidade de Dias: {this.qtddDias}" +
                $"Valor da Diária: {this.valorDiaria}" +
                $"Valor da Locação: {this.valorLocacao}");
        }


    }
}
