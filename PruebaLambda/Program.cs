
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
numeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 
    14});

// Hacemos uso de la expresión lambda para encontrar números pares
List<int> numPares = numeros.FindAll(x => (x % 2) == 0);

foreach (var item in numPares)
{
    Console.WriteLine(item);
}

// Hacemos uso de la expresión lambda para encontrar números primos
List<int> numPrimos = numeros.FindAll(n =>
{
    if (n <= 1)
        return false;
    if (n <= 3)
        return true;
    if (n % 2 == 0 || n % 3 == 0)
        return false;



    return true;
});

numPrimos.ForEach(x =>  Console.Write(x));


numPares.ForEach(n =>
{
    Console.WriteLine("El número par es: ");
    Console.WriteLine(n);
});

Client cliente4 = new Client();
cliente4.ID = 4;
cliente4.Name = "Pablo";

Client cliente5 = new Client();
cliente5.ID = 5;
cliente5.Name = "Luisa";

ComparaClientes comparaNombre = (c1, c2) => 
c1 == c2;

Console.WriteLine(comparaNombre(cliente4.Name, cliente5.Name));

delegate bool ComparaClientes(string n1, string n2);