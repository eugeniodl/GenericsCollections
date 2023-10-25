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

// Hacemos uso de expresiones Lambda para encontrar
// cliente con ID igual a 2

var client = clients.Find((Client c) =>
{
    return c.ID == 2;
});

var client2 = clients.Find(c => c.ID == 3);

if (client != null)
    Console.WriteLine(client.Name);
else
    Console.WriteLine("Client Not Found");


Client client3 = new Client();
client3.ID = 4;
client3.Name = "Pedro Tórrez";

Client client4 = new Client();
client4.ID = 5;
client4.Name = "Telma Bello";

CompareClient compareClient = (c1, c2) =>
c1 == c2;

Console.WriteLine(compareClient(client3.Name, 
    client4.Name));

List<int> numeros = new List<int>();
numeros.AddRange(Enumerable.Range(0, 100));

//Hacemos uso de expresiones lambda
//para obtener números pares
var numPares = numeros.FindAll(x => x % 2 == 0);

foreach (var num in numPares)
{
    Console.Write("{0,1} ", num);
}

numeros.ForEach(x => Console.Write("{0,1} ", x));

//Haciendo uso de expresiones lambda
//obtenga números primos


delegate bool CompareClient(string n1, string n2);





