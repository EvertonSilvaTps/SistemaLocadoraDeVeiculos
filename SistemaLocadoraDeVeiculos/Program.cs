using SistemaLocadoraDeVeiculos.Abstracts;
using SistemaLocadoraDeVeiculos.Entities;
using SistemaLocadoraDeVeiculos.Models;
using System.Xml.Serialization;

RentalCompany rentalCompany = new RentalCompany();

List<string> mainOptions = new List<string>()
{
    "1 - Menu Clientes",
    "2 - Menu Veículos",
    "3 - Menu Locações",
    "1 - Sair"
};

List<string> customerOptions = new List<string>()
{
    "Cadastrar Cliente",
    "Listar Cliente",
    "Atualizar Cliente",
    "Remover Cliente",
    "Voltar ao Menu Principal"
};

List<string> vehiclesOptions = new List<string>()
{
    "Cadastrar Veículo",
    "Listar Veículos",
    "Atualizar Veículo",
    "Remover Veículo",
    "Voltar ao Menu Principal"
};

List<string> rentalsOptions = new List<string>()
{
    "Cadastrar Locação",
    "Listar Locações",
    "Atualizar Locação",
    "Remover Locação",
    "Voltar ao Menu Principal"
};


void CreateCustomer()
{
    Console.WriteLine("Informe o nome do cliente:");
    string name = Console.ReadLine() ?? "";
    Console.WriteLine("Informe a data de nascimento do cliente:");
    DateOnly birthDate = DateOnly.Parse(Console.ReadLine() ?? "");
    Console.WriteLine("Informe o email do cliente:");
    string email = Console.ReadLine() ?? "";
    Console.WriteLine("Informe o logradouro do cliente: ");
    string street = Console.ReadLine() ?? "";
    Console.WriteLine("Informe o número do endereço do cliente: ");
    string number = Console.ReadLine() ?? "";
    Console.WriteLine("Informe o complemento do endereço do cliente: ");
    string complement = Console.ReadLine() ?? "";
    Console.WriteLine("Informe o bairro do cliente: ");
    string neighborhood = Console.ReadLine() ?? "";
    Console.WriteLine("Informe a cidade do cliente: ");
    string city = Console.ReadLine() ?? "";
    Console.WriteLine("Informe o estado do cliente: ");
    string state = Console.ReadLine() ?? "";
    Console.WriteLine("Informe o CEP do cliente: ");
    string zipCode = Console.ReadLine() ?? "";

    var contact = new Contact(email, null);
    var address = new Address(street, int.Parse(number), neighborhood, zipCode, complement, city, state, "BR");

    Console.WriteLine("Qual tipo do cliente está cadastrando? (1 para PF, 2 para PJ):");
    int customerType = int.Parse(Console.ReadLine() ?? "1");
    if (customerType == 1)
    {
        Console.WriteLine("Informe o número da CNH: ");
        string cnh = Console.ReadLine() ?? "";
        Console.WriteLine("Informe o número da CPF: ");
        string cpf = Console.ReadLine() ?? "";
        var customer = new CustomerPF(name, birthDate, contact, address, cnh, cpf);
        rentalCompany.Customers.Add(customer);
    }
    else
    {
        Console.WriteLine("Informe o CNPJ da empresa: ");
        string cnpj = Console.ReadLine() ?? "";
        var customer = new CustomerPJ(name, birthDate, contact, address, cnpj);
        rentalCompany.Customers.Add(customer);
    }
}

Person FindCustomerByName(string name)
{
    return rentalCompany.Customers.Find(c => c.GetName() == name);
}


void DeleteCustomer()
{
    Console.WriteLine("Informe o nome do cliente a ser removido:");
    string name = Console.ReadLine() ?? "";
    var customer = FindCustomerByName(name);
    if (customer is not null)
    {
        rentalCompany.Customers.Remove(customer);
        Console.WriteLine("Cliente removido com sucesso.");
    }
    else
    {
        Console.WriteLine("Cliente não encontrado.");
    }
}


Person UpdatePhone()
{
    Console.WriteLine("Informe o nome do cliente a ser atualizado: ");
    string name = Console.ReadLine() ?? "";
    var customer = FindCustomerByName(name);
    if (customer is not null)
    {
        Console.WriteLine("Informe o telefone do cliente: ");
        string phone = Console.ReadLine() ?? "";
        customer.setContactPhone(phone);
        Console.WriteLine("Telefone atualizado com sucesso.");
    }
    else
    {
        Console.WriteLine("Cliente não encontrado.");
    }
        return customer;
}


void ListCustomers()
{
    Console.WriteLine("=== Lista de Clientes ===");
    foreach(var customer in rentalCompany.Customers)
    {
        Console.WriteLine(customer);
        //Console.WriteLine(customer.ToString());
    }
}



void CustomerMenu(int option)
{
    switch (option)
    {
        case 1:
            CreateCustomer();
            break;
        case 2:
            ListCustomers();
            break;
        case 3:
            Console.WriteLine(UpdatePhone());
            break;
        case 4:
            DeleteCustomer();
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
}



do
{
    int mainChoice = Menu.Display("=== Menu Principal ===", mainOptions);

    switch (mainChoice)
    {
        case 1:
            int customerChoice = Menu.Display("Menu Clientes ===", customerOptions);
            CustomerMenu(customerChoice);
            break;
        case 2:
            int vehicleChoice = Menu.Display("Menu Veículos ===", vehiclesOptions);
            break;
        case 3:
            int rentalChoice = Menu.Display("Menu Locações ===", rentalsOptions);
            break;
        case 4:
            Console.WriteLine("Saindo do programa...");
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;

    }
} while (true);