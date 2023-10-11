string[] colores =
    { "MAGENTA", "ROJO", "BLANCO", "AZUL", "CYAN"};
string[] eliminarColores =
    { "ROJO", "BLANCO", "AZUL" };

List<string> lista = new List<string>();

Console.WriteLine($"Capacidad de la lista {lista.Capacity}");

foreach (var color in colores)
{
    lista.Add(color);
}

List<string> eliminarLista = new List<string>(eliminarColores);

MostrarInformacion(lista);

EliminarColores(lista, eliminarColores);

EliminarListaColores(lista, eliminarLista);

void EliminarListaColores(List<string> lista, 
    List<string> eliminarLista)
{
    foreach(var item in eliminarLista)
    {
        lista.Remove(item);
    }
}

void EliminarColores(List<string> lista, string[] eliminarColores)
{
    for (int i = 0; i < eliminarColores.Length; i++)
    {
        lista.Remove(eliminarColores[i]);
    }
}

MostrarInformacion(lista);

void MostrarInformacion(List<string> lista)
{
    foreach (var item in lista)
    {
        Console.Write($"{item} ");
    }

    Console.WriteLine($"\nTamaño = {lista.Count}; " +
        $"Capacidad = {lista.Capacity}");

    int index = lista.IndexOf("AZUL");

    if(index != -1)
        Console.WriteLine($"La lista contiene AZUL en el índice " +
            $"{index}");
    else
        Console.WriteLine("La lista no contiene AZUL");
}

// Elimine de primera Lista los colores especificados
// en la segunda Lista

