
using PruebaLambda;

List<Client> clientes = new List<Client>()
{
    new Client()
    {
        ID = 1,
        Name = "Emanuel",
    },
    new Client()
    {
        ID = 2,
        Name = "Rosa",
    },
    new Client()
    {
        ID = 3,
        Name = "Francisco",
    },
};

var cliente = clientes.Find((Client c) =>
{
    return c.ID == 2;
});

var cliente2 = clientes.Find(c => c.ID == 20);

if(cliente2 != null)
    Console.WriteLine(cliente2.Name);
else
    Console.WriteLine("Cliente no encontrado");


//int BuscarCliente(Client c)
//{
//    return c.ID;
//}

Console.WriteLine("-------------------------");

List<int> numeros = new List<int>();
numeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10});

// Hacemos uso de la expresión lambda para encontrar números pares
List<int> numPares = numeros.FindAll(x => (x % 2) == 0);

foreach (var item in numPares)
{
    Console.WriteLine(item);
}