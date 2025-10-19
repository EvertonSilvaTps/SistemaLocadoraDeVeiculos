using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraDeVeiculos
{
    public class Moto : Veiculo
    {
        public int Ano { get; set; }

        // Criado uma lista para motos. 'List<>' do tipo 'Moto'
        public static List<Moto> ListaDeMotos = new List<Moto>();



        // Exibição das propriedades da moto   | Pilar > Polimorfismo (Sobreposição)
        public override void ExibirInformacoes()
        {
            Console.WriteLine("\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine($"Marca: {this.Marca}");
            Console.WriteLine($"Modelo: {this.Modelo}");
            Console.WriteLine($"Ano: {this.Ano}");
            Console.WriteLine($"Cor: {this.Cor}");
            Console.WriteLine($"Placa: {this.Placa}");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        }



        // Motos Pré-Cadastradas (adicionado na lista)
        public static void MotosCadastrados()
        {
            ListaDeMotos.Add(new Moto { Marca = "Honda", Modelo = "CG 160 Titan", Ano = 2015, Cor = "Preto", Placa = "JVS5681" });
            ListaDeMotos.Add(new Moto { Marca = "Suzuki", Modelo = "Gixxer SF", Ano = 2022, Cor = "Prata", Placa = "GHI9012" });
            ListaDeMotos.Add(new Moto { Marca = "Honda", Modelo = "CB 250F Twister", Ano = 2025, Cor = "Vermelha", Placa = "DEF5678" });
            ListaDeMotos.Add(new Moto { Marca = "Yamaha", Modelo = "YBR 150 Factor", Ano = 2018, Cor = "Cinza", Placa = "GHI9012" });
            ListaDeMotos.Add(new Moto { Marca = "Yamaha", Modelo = "Fazer 250", Ano = 2024, Cor = "Azul", Placa = "JKL3456" });
        }



        // Cadastro de nova moto, em seguida é inserido na lista
        public static void Cadastrar()
        {
            Moto novo = new Moto();

            Console.Write("Marca: ");
            novo.Marca = Console.ReadLine();
            Console.Write("Modelo: ");
            novo.Modelo = Console.ReadLine();

            bool EhNumero;
            int n;
            do
            {
                Console.Write("Ano: ");
                EhNumero = int.TryParse(Console.ReadLine(), out n);
                if (!EhNumero)
                    Console.WriteLine("Valor inválido! Digite apenas números.");
            } while (!EhNumero);
            novo.Ano = n;

            Console.Write("Cor: ");
            novo.Cor = Console.ReadLine();
            Console.Write("Placa: ");
            novo.Placa = Console.ReadLine();

            //Adicionado na lista
            ListaDeMotos.Add(novo);
            novo.ExibirInformacoes();
            Console.WriteLine("\nMoto cadastrada!");
        }



        // Exibição das motos que estão adicionados na lista, usando a função ExibirInformações
        public static void ExibirLista()
        {
            Console.WriteLine("\n =-=-=-=-= Lista de Motos =-=-=-=-=");

            foreach (Moto moto in ListaDeMotos)
            {
                moto.ExibirInformacoes();
            }
        }
    }
}
