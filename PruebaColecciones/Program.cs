using System.Collections.ObjectModel;

// Cree una colección de frutas
Collection<string> frutas = new Collection<string>();
frutas.Add("Limón");
frutas.Add("Manzana");
frutas.Add("Fresa");
frutas.Add("Pitahaya");
frutas.Add("Sandía");

// Imprimir la colección
Display(frutas);

// Insertar un elemento a la colección
frutas.Insert(3, "Uva");
Display(frutas);

// Verificar si en la colección está la naranja
Console.WriteLine($"La colección contiene la naranja: " +
    $"{frutas.Contains("Naranja")}");

// Remover el índice 2 de la colección
//frutas.Remove("Uva");
frutas.RemoveAt(2);

// Imprimir la colección
Display(frutas);

// Contar elementos de la colección
Console.WriteLine($"La colección tiene {frutas.Count} elementos");

void Display(Collection<string> frutas)
{
    foreach (var fruta in frutas)
    {
        Console.WriteLine(fruta);
    }
    Console.WriteLine("---------------------------");
}
