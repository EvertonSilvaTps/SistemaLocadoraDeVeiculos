using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraDeVeiculos
{
    public class Locacao
    {
        public Cliente Cliente {  get; set; }
        public Veiculo Veiculo { get; set; }
        public double valorLocacao { get; set; }
        public int dias {  get; set; }
        public double diaria { get; set; }

        public static List<Locacao> Locacoes = new List<Locacao>();

        public Locacao(Cliente cliente, Veiculo veiculo, int dias, double diaria)
        {
            this.Cliente = cliente;
            this.Veiculo = veiculo;
            this.dias = dias;
            this.diaria = diaria;
            this.valorLocacao = dias * diaria;

        }

        public override string ToString()
        {
            return ($"\n Cliente: {Cliente.Nome}" +
                $"\n Veículo: Modelo {Veiculo.Modelo} | Marca {Veiculo.Marca}" +
                $"\n Dias de locação: {dias} | Valor da diária: R$ {diaria:F2} | Valor Total: R$ {valorLocacao:F2}");
        }


        public static void ListarLocacoes()
        {
            if (Locacao.Locacoes.Count == 0)
            {
                Console.WriteLine("\n Não há nenhuma locação registrada.");
                Console.ReadLine();
                return;
            }
            Console.Clear();
            Console.WriteLine("\n=-=-=-=-=  Locações Registradas  =-=-=-=-=");
            foreach (Locacao locacao in Locacao.Locacoes)
                Console.WriteLine(locacao);
            Console.ReadLine();
        }

    }
}
