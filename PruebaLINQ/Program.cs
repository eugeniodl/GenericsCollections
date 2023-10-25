
// 1. Data source.
using System;

int[] numeros = Enumerable.Range(1, 100).ToArray();

// 2. Query creation.
IEnumerable<int> numPares =
    from num in numeros
    where num % 2 == 0
    select num;

// 3. Query execution.
foreach (var num in numPares)
{
    Console.Write("{0,1} ", num);
}
