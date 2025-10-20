using SistemaLocadoraDeVeiculos;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

int opcao;


// Método > Menu Principal: Programa Final
void MenuPrincipal()
{
    do
    {
        Console.Clear();
        Console.WriteLine(" |-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=|");
        Console.WriteLine(" |           >      Sistema de Locadora de Veículos      <          |");
        Console.WriteLine(" |------------------------------------------------------------------|");
        Console.WriteLine(" |     [ 1 ] Cadastrar Veículo     |     [ 2 ] Cadastrar Cliente    |");
        Console.WriteLine(" |     [ 3 ] Lista de Veículos     |     [ 4 ] Lista de Clientes    |");
        Console.WriteLine(" |     [ 5 ] Registrar Locação     |     [ 6 ] Remover Locação      |");
        Console.WriteLine(" |     [ 7 ] Lista de Locações     |     [ 8 ] Sair                 |");
        Console.WriteLine(" |-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=|");
        Console.WriteLine();
        Console.Write("  >>> Informe o menu desejado: ");
        opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                CadasVeiculo();
                break;
            case 2:
                Cliente.CadastroDeCliente();
                break;
            case 3:
                ExibirVeiculos();
                break;
            case 4:
                Cliente.ExibirLista();
                break;
            case 5:
                RegistrarLocacao();
                break;
            case 6:
                RemoverLocacao();
                break;
            case 7:
                Locacao.ListarLocacoes();
                break;
            default:
                Console.WriteLine(" Encerrando o programa...");
                break;
        }
        if (opcao == 8)
            Console.ReadLine();
    } while (opcao != 8);
}



// Método > Cadastro de veículos
void CadasVeiculo()
{
    int es;
    do
    {
        Console.Clear();
        Console.WriteLine("|------------------------------------------------------------------|");
        Console.WriteLine("|                         Tipos de Veículos                        |");
        Console.WriteLine("|------------------------------------------------------------------|");
        Console.WriteLine("|  [ 1 ] Carro  |  [ 2 } Moto  |  [ 3 ] Caminhão  |  [ 4 ] Voltar  |");
        Console.WriteLine("|------------------------------------------------------------------|");
        Console.WriteLine();
        Console.Write("\n  Informe o número do veículo: ");
        es = int.Parse(Console.ReadLine());

        switch (es)
        {
            case 1:
                Console.Clear();
                Carro.Cadastrar();
                break;
            case 2:
                Console.Clear();
                Moto.Cadastrar();
                break;
            case 3:
                Console.Clear();
                Caminhao.Cadastrar();
                break;
            default:
                break;
        }
    } while (es != 4);
}



// Método > Lista de veículos
void ExibirVeiculos()
{
    Carro.ExibirLista();
    Console.ReadLine();
    Moto.ExibirLista();
    Console.ReadLine();
    Caminhao.ExibirLista();
    Console.ReadLine();
}



// Método > Registro de Locação : Leitura do cliente; do veículo; dias e valor da diária
void RegistrarLocacao()
{
    Console.Clear();
    if (Cliente.ListaDeClientes.Count == 0)    // Caso não tenha cliente cadastrado
    {
        Console.WriteLine("\n Não há registros de clientes. É necessário cadastrar primeiro.");
        Console.ReadLine();
        return;
    }


    Console.WriteLine("\n=-=-=-=-=  Clientes Cadastrados  =-=-=-=-=\n");   // Exibir indices de clientes, e em seguida a escolha pelo usuário.
    for (int i = 0; i < Cliente.ListaDeClientes.Count; i++)
    {
        Console.WriteLine($"[ {i} ] - {Cliente.ListaDeClientes[i].Nome}");
    }

    Console.Write("\nInforme o número do cliente: ");
    int op = int.Parse(Console.ReadLine());
    Cliente escolhaCliente = Cliente.ListaDeClientes[op];   // Tipo Cliente, conforme pede o construtor Locação

    Console.WriteLine("\n=-=-=-=-=  Veículos Cadastrados  =-=-=-=-=\n");    // Exibir indices de veículos, e em seguida a escolha pelo usuário.
    int cont = 0;
    List<Veiculo> todosVeiculos = new List<Veiculo>();

    foreach (Carro carro in Carro.ListaDeCarros)
    {
        Console.WriteLine($"{cont} - Carro: {carro.Modelo} | Marca: {carro.Marca}");
        todosVeiculos.Add(carro);
        cont++;
    }
    Console.WriteLine();
    foreach (Moto moto in Moto.ListaDeMotos)
    {
        Console.WriteLine($"{cont} - Moto: {moto.Modelo} | Marca: {moto.Marca}");
        todosVeiculos.Add(moto);
        cont++;
    }
    Console.WriteLine();
    foreach (Caminhao caminhao in Caminhao.ListaDeCaminhoes)
    {
        Console.WriteLine($"{cont} - Caminhão: {caminhao.Modelo} | Marca: {caminhao.Marca}");
        todosVeiculos.Add(caminhao);
        cont++;
    }

    Console.Write("\nInforme o número do veículo: ");
    int opc = int.Parse(Console.ReadLine());
    Veiculo escolhaVeiculo = todosVeiculos[opc];   // Tipo Veículo, conforme pede o construtor Locação

    Console.Write("Quantidade de dias da locação: ");
    int dias = int.Parse(Console.ReadLine());    // Tipo Int, conforme pede o construtor Locação
    Console.Write("Valor da diária: R$ ");
    double diaria = double.Parse(Console.ReadLine());    // Tipo Double, conforme pede o construtor Locação

    Locacao novaLocacao = new Locacao(escolhaCliente, escolhaVeiculo, dias, diaria);  // Usado construtor da classe Locação
    Locacao.Locacoes.Add(novaLocacao);

    Console.WriteLine("\n=-=-=-=-=  Locação Registrada  =-=-=-=-=\n");
    Console.WriteLine(novaLocacao);  // Impressão
    Console.ReadLine();
}



// Método > Remover Locação
void RemoverLocacao()
{
    Console.Clear();
    if (Locacao.Locacoes.Count == 0)
    {
        Console.WriteLine("\n Nenhuma locação foi registrada.");
        Console.ReadLine();
        return;
    }

    Console.WriteLine("\n =-=-=-=-=  Locações Registradas  =-=-=-=-=\n");
    for (int i = 0; i < Locacao.Locacoes.Count; i++)
    {
        Console.WriteLine($"[ {i} ] - {Locacao.Locacoes[i]}");
    }

    Console.Write(" Informe o número da locação que deseja remover: ");
    int esc = int.Parse(Console.ReadLine());

    if (esc >= 0 && esc < Locacao.Locacoes.Count)
    {
        Locacao.Locacoes.RemoveAt(esc);             // O RemoveAt ele remove com base ao índice
        Console.WriteLine(" Locação removida!");
    }
    else
        Console.WriteLine(" Número inválido!");
    Console.ReadLine();
}



// Método > Chamando as funções de Veículos Cadastrados
void InicializarVeiculosPréCadastrados()
{
    Carro.CarrosCadastrados();
    Moto.MotosCadastradas();
    Caminhao.CaminhoesCadastrados();
}




// Rodar o programa
InicializarVeiculosPréCadastrados();
MenuPrincipal();