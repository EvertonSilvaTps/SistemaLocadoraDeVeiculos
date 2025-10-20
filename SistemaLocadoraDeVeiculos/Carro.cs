using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraDeVeiculos
{
    public class Carro : Veiculo  //   | Pilar > Herança
    {
        public string Tipo { get; set; }
        public int Cambio { get; set; }

        // Criado uma lista para carros. 'List<>' do tipo 'Carro'
        public static List<Carro> ListaDeCarros = new List<Carro>();



        // Exibição das propriedades do carro   | Pilar > Polimorfismo (Sobreposição)
        public override void ExibirInformacoes()
        {
            Console.WriteLine($"  Marca: {this.Marca}    |  Tipo: {this.Tipo}  |  Modelo: {this.Modelo}");
            if (this.Cambio == 1)
                Console.WriteLine($"  Câmbio: Manual  |  Cor: {this.Cor}  |  Placa: {this.Placa}");
            if (this.Cambio == 2)
                Console.WriteLine($"  Câmbio: Automático  |  Cor: {this.Cor}  |  Placa: {this.Placa}");
            Console.WriteLine("  -----------------------------------------------------------------");
        }



        // Carros Pré-Cadastrados (adicionado na lista)
        public static void CarrosCadastrados()
        {
            if (ListaDeCarros.Count == 0)
            {                                                  // variávelLista.Add(new Tipo { conteúdo que será adicionado });
                ListaDeCarros.Add(new Carro { Marca = "Chevrolet", Tipo = "Health", Modelo = "Onix", Cambio = 2, Cor = "Preto", Placa = "KMS467" });
                ListaDeCarros.Add(new Carro { Marca = "Honda", Tipo = "Sedan", Modelo = "Civic", Cambio = 2, Cor = "Prata", Placa = "VNS173" });
                ListaDeCarros.Add(new Carro { Marca = "Chevrolet", Tipo = "SUV", Modelo = "Spin", Cambio = 1, Cor = "Cinza", Placa = "DNC789" });
                ListaDeCarros.Add(new Carro { Marca = "Fiat", Tipo = "Picape", Modelo = "Strada", Cambio = 1, Cor = "Branco", Placa = "HBJ196" });
            }
        }



        // Cadastro de novo carro, em seguida é inserido na lista
        public static void Cadastrar()
        {
            Carro novo = new Carro();  // Criado variável do tipo Carro

            //Leitura das propriedades do Carro
            Console.Write(" Marca: ");
            novo.Marca = Console.ReadLine();
            Console.Write(" Tipo [Ex: Health, Sedan, SUV]: ");
            novo.Tipo = Console.ReadLine();
            Console.Write(" Modelo: ");
            novo.Modelo = Console.ReadLine();
            do
            {
                Console.Write(" Câmbio [1 - Manual] [2 - Automático]: ");
                novo.Cambio = int.Parse(Console.ReadLine());
            } while (novo.Cambio != 1 && novo.Cambio != 2);
            
            Console.Write(" Cor: ");
            novo.Cor = Console.ReadLine();
            Console.Write(" Placa: ");
            novo.Placa = Console.ReadLine();

            //Adicionado na lista
            ListaDeCarros.Add(novo);
            novo.ExibirInformacoes();
            Console.WriteLine("\n Carro cadastrado!");
        }



        // Exibição dos carro que estão adicionados na lista, usando a função ExibirInformações
        public static void ExibirLista()
        {
            Console.Clear();
            Console.WriteLine("\n -=-=-=-=-=-=-=-=-=-=     Lista de Carros     =-=-=-=-=-=-=-=-=-=-=\n");
            
            foreach(Carro carro in ListaDeCarros)
            {
                carro.ExibirInformacoes();
            }
        }
    }
}
