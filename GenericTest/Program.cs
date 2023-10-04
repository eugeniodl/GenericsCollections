// create arrays of int, double and char
int[] intArray = { 1, 2, 3, 4, 5, 6};
double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };
char[] charArray = { 'H', 'E', 'L', 'L', 'O' };

Console.WriteLine("Array intArray contains: ");
DisplayArray(intArray); // pass an int array argument
Console.WriteLine("Array doubleArray contains: ");
DisplayArray(doubleArray); // pass an double array argument
Console.WriteLine("Array charArray contains: ");
DisplayArray(charArray); // pass an char array argument

// output array of all types
void DisplayArray<T>(T[] inputArray)
{
    foreach (var item in inputArray)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}
