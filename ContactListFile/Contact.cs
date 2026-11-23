public class Contact(string n, string p, string a)
{
    //public int Id { get; set; }
    public string Name { get; set; } = n;
    public string Phone { get; set; } = p;
    public string Adress { get; set; } = a;

    public override string ToString()
    {
        return $"""
            Nome: {Name}
            Telefone: {Phone}
            Endereço: {Adress}
            """;
    }


    public string ToFile()
    {
        return $"{Name},{Phone},{Adress}";
    }
}

