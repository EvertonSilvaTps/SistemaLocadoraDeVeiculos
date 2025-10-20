using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLocadoraDeVeiculos
{
    public class Cliente : Pessoa
    {
        public char CNH { get; set; }
        public static List<Cliente> ListaDeClientes = new List<Cliente>();

        public static void CadastroDeCliente()
        {
            Cliente novo = new Cliente();

            Console.WriteLine("\n Regras para ser cliente:\n");
            Console.WriteLine("  . Ser maior de idade");
            Console.WriteLine("  . Possuir CNH\n");

            Console.Write(" Nome: ");
            novo.Nome = Console.ReadLine();
            Console.Write(" Idade: ");
            novo.Idade = int.Parse(Console.ReadLine());
            Console.Write(" Tem CNH? [S/N]: ");
            novo.CNH = char.ToUpper(char.Parse(Console.ReadLine()));
            if (novo.Verificacao())
            {
                ListaDeClientes.Add(novo);
                Console.WriteLine("\n Cadastro efetuado com sucesso!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"\n Cadastro inválido! {novo.Nome} não cumpre requisitos para locar um veículo");
                Console.ReadLine();
            }
        }

        public bool Verificacao()
        {
            if (this.Idade >= 18 && this.CNH == 'S')
                return true;
            return false;
        }


        public static void ExibirLista()
        {
            Console.Clear();
            Console.WriteLine("\n -=-=-=-=-=  Lista de Clientes  =-=-=-=-=-");

            if (ListaDeClientes.Count == 0)
            {
                Console.WriteLine(" \n Nenhum cliente foi registrado.");
                Console.ReadLine();
                return;
            }

            foreach (Cliente cliente in ListaDeClientes)
            {
                Console.WriteLine($" \n> Nome: {cliente.Nome}");
                Console.WriteLine($" > Idade: {cliente.Idade}");
            }
            Console.ReadLine();
        }



    }
}
