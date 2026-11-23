var path = @"C:\Users\DiogoCunha\source\repos\csharp-exercises-23-11-26\";
var file = "ContactList.txt";

List<Contact> contacts = new();
List<Contact> recoveredContacts = new();

void RegisterContact()
{
    bool registerAnother = true;

    while (registerAnother)
    {
        Console.Write("Digite seu nome: ");
        string n = Console.ReadLine();
        Console.Write("Digite seu telefone: ");
        string p = Console.ReadLine();
        Console.Write("Digite seu endereço: ");
        string a = Console.ReadLine();


        var c = new Contact(n, p, a);
        contacts.Add(c);

        Console.WriteLine("Você deseja registrar outro contato (s/n)?");
        char otherContact = char.Parse(Console.ReadLine());

        if (otherContact == 'n')
        {
            registerAnother = false;
        }
        else if (otherContact != 's')
        {
            Console.WriteLine("Entrada inválida.");
        }
    }
}


void SaveContacts()

{
    var writer = new StreamWriter(path + file, true);
    foreach (Contact c in contacts)
    {
        writer.WriteLine(c.ToFile());

    }
    writer.Close();

}

void ReadContacts()
{
    var reader = new StreamReader(path + file);
    string? line = reader.ReadLine();
    while (line != null)
    {
        string[] RecoveryDatas = line.Split(',');
        var c = new Contact(RecoveryDatas[0], RecoveryDatas[1], RecoveryDatas[2]);
        recoveredContacts.Add(c);
        line = reader.ReadLine();
    }
    reader.Close();

    Console.WriteLine("Dados recuperados do arquivo: ");
    foreach (Contact c in recoveredContacts)
    {
        Console.WriteLine(c);
    }

}
void Main()
{
    int option = -1;

    while (option != 0)
    {
        Console.WriteLine("""
            Selecione qual opção você deseja:

            1 - Cadastrar novo contato.
            2 - Salvar contatos no arquivo.
            3 - Recuperar contatos do arquivo.
            0 - Sair.
            """);

        option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                RegisterContact();
                break;

            case 2:
                SaveContacts();
                break;

            case 3:
                ReadContacts();
                break;

            case 0:
                Console.WriteLine("Obrigado por utilizar nosso sistema de agenda de contatos.");
                break;

            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
}

Main();

