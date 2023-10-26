// 1. Data source.
int[] numbers = Enumerable.Range(1, 100).ToArray();

// 2. Query creation.
IEnumerable<int> evenNumbers =
    from num in numbers
    where num % 2 == 0
    select num;

// 3. Query execution.
foreach (var num in evenNumbers)
{
    Console.Write("{0,1} ", num);
}

// Mostrar en consola todos los números primos
Console.WriteLine("\nNúmeros primos del 1 al 100");

List<int> numeros = new List<int>();
numeros.AddRange(numbers);

var primos = 
    (from num in numeros
    select num)
    .Where(num => EsPrimo(num))
    .ToList();

bool EsPrimo(int n)
{
    if(n <= 1)
        return false;
    else
        for (int i = 2; i < n - 1; i++)
        {
            if (n % i == 0)
                return false;
        }
    return true;
}

primos.ForEach(x => Console.Write("{0,1} ", x));

// Mostrar la suma de todos los elementos
Console.WriteLine($"\nSuma de todos los elementos: {numbers.Sum()}");

// Generar una nueva lista con el cuadrado de los números
var cuadrados = numeros.Select(x => x * x).ToList();
Console.WriteLine("\nNueva lista con el cuadrado de los números");
Console.WriteLine(string.Join(", ", cuadrados));

// Obtener el promedio de todos los números mayores a 50
var promedioMayoresA50 = 
    (from num in numeros
    where num > 50
    select num)
    .Average();
Console.WriteLine($"\nPromedio de números mayores a 50: {promedioMayoresA50}");

// Contar la cantidad de números pares e impares en una única query
var conteoParesImpares = numeros.GroupBy(num => num % 2 == 0)
                                .ToDictionary(group => group.Key ? "Pares" : "Impares", 
                                group => group.Count());

Console.WriteLine("Cantidad de números pares e impares");
foreach (var kvp in conteoParesImpares)
{
    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
}

// Contar la frecuencia de cada número de la lista 1, 2, 1, 2, 3, 1
List<int> lst = new List<int>()
{ 1, 2, 1, 2, 3, 1 };

var conteoNumeros = lst.GroupBy(num => num)
    .Select(group => new
    {
        Numero = group.Key,
        Cantidad = group.Count()
    });

foreach (var item in conteoNumeros)
{
    Console.WriteLine($"Número: {item.Numero}, Cantidad: {item.Cantidad} ");
}