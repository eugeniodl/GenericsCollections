//Hacemos uso de LINQ
//para obtener números pares

// 1. Specify the data source.
List<int> numbers = new List<int>();
numbers.AddRange(Enumerable.Range(1, 100));

// 2. Define the query expression.
var evenNumbers = 
    from num in numbers
    where (num % 2) == 0
    select num;

// 3. Execute the query.
foreach (var i in evenNumbers)
{
    Console.Write(i + " ");
}

// Mostrar en consola todos los números primos
var primes = (from num in numbers
             select num)
             .Where(num => IsPrime(num)).ToList();

bool IsPrime(int n)
{
   if(n <= 1)
        return false;
   else
        for (int i = 2; i < n - 1; i++)
        {
            if(n % i == 0)
                return false;
        }
   return true;
}

Console.WriteLine("\nNúmeros primos");
primes.ForEach(x => Console.Write($"{x} "));

// Mostrar en consola la suma de todos los elementos
Console.WriteLine($"\nSuma de todos los elementos: {numbers.Sum()}");

// Generar una nueva lista con el cuadrado de todos los elementos
var squares = numbers.Select(x => x * x).ToList();
Console.WriteLine("Nueva lista con el cuadrado de todos los elementos");
Console.WriteLine(String.Join(", ", squares));

// Obtener el promedio de todos los números mayores a 50
var greaterThan50Average = numbers
                           .Where(x => x > 50)
                           .Average();
Console.WriteLine($"Promedio de números mayores a 50: " +
    $"{greaterThan50Average}");

// Contar la cantidad de números pares e impares en una única lista
var oddEvenCounting = primes.GroupBy(num => num % 2 == 0)
                      .ToDictionary(group => group.Key ? "Evens" : "Odds",
                               group => group.Count());
Console.WriteLine("Cantidad de números pares e impares");
foreach (var item in oddEvenCounting)
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}

// Utilice LINQ para contar la frecuencia de cada número en la lista
// 1, 2, 1, 2, 3, 1 
List<int> numeros = new List<int> { 1, 2, 1, 2, 3, 1 };

var numbersCounting = numeros.GroupBy(num => num)
                      .Select(group => new
                      {
                          Numero = group.Key,
                          Cantidad = group.Count()
                      });

foreach (var item in numbersCounting)
{
    Console.WriteLine($"Número: {item.Numero}, Cantidad: {item.Cantidad}");
}