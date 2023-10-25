//Hacemos uso de LINQ
//para obtener números pares

// 1. Specify the data source.
List<int> numeros = new List<int>();
numeros.AddRange(Enumerable.Range(0, 100));

// 2. Define the query expression.
var numPares = 
    from num in numeros
    where (num % 2) == 0
    select num;

// 3. Execute the query.
foreach (var i in numPares)
{
    Console.Write(i + " ");
}