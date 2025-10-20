using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraDeVeiculos
{
    public class Caminhao : Veiculo
    {
        public string Carga { get; set; }

        // Criado uma lista para caminhões. 'List<>' do tipo 'Caminhao'
        public static List<Caminhao> ListaDeCaminhoes = new List<Caminhao>();



        // Exibição das propriedades do caminhão   | Pilar > Polimorfismo (Sobreposição)
        public override void ExibirInformacoes()
        {
            Console.WriteLine($"  Marca: {this.Marca}  |  Modelo: {this.Modelo}  |  Carga: {this.Carga}");
            Console.WriteLine($"  Cor: {this.Cor}  |  Placa: {this.Placa}");
            Console.WriteLine("  ---------------------------------------------------------------------");
        }



        // Caminhões Pré-Cadastradas (adicionado na lista)
        public static void CaminhoesCadastrados()
        {
            if (ListaDeCaminhoes.Count == 0)
            {
                ListaDeCaminhoes.Add(new Caminhao { Marca = "Mercedes-Benz", Modelo = "Accelo 1016", Carga = "4 toneladas", Cor = "Branco", Placa = "ABC1234" });
                ListaDeCaminhoes.Add(new Caminhao { Marca = "Volkswagen", Modelo = "Delivery 9.160", Carga = "4,5 toneladas", Cor = "Prata", Placa = "DEF5678" });
                ListaDeCaminhoes.Add(new Caminhao { Marca = "Ford", Modelo = "Cargo 815", Carga = "6 toneladas", Cor = "Azul", Placa = "GHI9012" });
                ListaDeCaminhoes.Add(new Caminhao { Marca = "Volvo", Modelo = "VM 270", Carga = "7 toneladas", Cor = "Branco", Placa = "JKL3456" });
            }
        }



        // Cadastro de novo caminhão, em seguida é inserido na lista
        public static void Cadastrar()
        {
            Caminhao novo = new Caminhao();

            Console.Write(" Marca: ");
            novo.Marca = Console.ReadLine();
            Console.Write(" Modelo: ");
            novo.Modelo = Console.ReadLine();
            Console.Write(" Carga: ");
            novo.Carga = Console.ReadLine();
            Console.Write(" Cor: ");
            novo.Cor = Console.ReadLine();
            Console.Write(" Placa: ");
            novo.Placa = Console.ReadLine();

            //Adicionado na lista
            ListaDeCaminhoes.Add(novo);
            novo.ExibirInformacoes();
            Console.WriteLine("\n Caminhão cadastrado!");
        }



        // Exibição dos caminhões que estão adicionados na lista, usando a função ExibirInformações
        public static void ExibirLista()
        {
            Console.Clear();
            Console.WriteLine("\n -=-=-=-=-=-=-=-=-=-=     Lista de Caminhões     =-=-=-=-=-=-=-=-=-=-=\n");

            foreach (Caminhao caminhao in ListaDeCaminhoes)
            {
                caminhao.ExibirInformacoes();
            }
        }
    }
}
