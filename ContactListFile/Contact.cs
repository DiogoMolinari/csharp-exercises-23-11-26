public class Contact(string n)
{
    //public int Id { get; set; }
    public string Name { get; private set; } = n;
    public string Phone { get; set; }
    public char Gender { get; set; }

    public override string ToString()
    {
        return $"""
            Nome: {Name}
            Telefone: {Phone}
            Sexo: {Gender}
            """;
    }

}

