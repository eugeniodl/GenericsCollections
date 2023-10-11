// Crear una colección genérica
// de 5 frutas
using System.Collections.ObjectModel;

Collection<string> frutas = new Collection<string>();
frutas.Add("Manzana");
frutas.Add("Pera");
frutas.Add("Sandía");
frutas.Add("Kiwi");
frutas.Add("Uva");

// Mostrar la información de la
// colección (elementos, tamaño)
Display(frutas);
Console.WriteLine($"El tamaño de la colección es " +
    $"{frutas.Count}");

// Buscar en la colección la 
// fruta naranja e imprimir
Console.WriteLine($"La colección contiene naranja: " +
    $"{frutas.Contains("naranja")}");

// Insertar por índice una nueva
// fruta e imprimir
frutas.Insert(3, "Naranja");
Display(frutas);

// Remover la fruta insertada
frutas.Remove("Naranja");
Display(frutas);

// Remover la fruta 0
// Imprimir
frutas.RemoveAt(0);
Display(frutas);

void Display(Collection<string> frutas)
{
    foreach (var fruta in frutas)
    {
        Console.WriteLine(fruta);
    }
    Console.WriteLine("-----------------------");
}