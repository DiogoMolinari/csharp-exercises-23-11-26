List<Contact> contacts = new();

var c = new Contact("Diogo");
c.Phone = "123456";
c.Gender = 'M';
contacts.Add(c);


c = new("Felipe");
contacts.Add(c);

foreach (var item in contacts)
{
    Console.WriteLine(item);
}

