

using PruebaLambda;

List<Client> clients = new List<Client>()
{
    new Client()
    {
        ID = 1,
        Name = "Emanuel Reyes",
    },
    new Client()
    {
        ID = 2,
        Name = "Rosa Ordoñez",
    },
    new Client()
    {
        ID = 3,
        Name = "Freddy García",
    },
};

var client = clients.Find((Client c) =>
{
    return c.ID == 2;
});

if (client != null)
    Console.WriteLine(client.Name);
else
    Console.WriteLine("Client Not Found");
