string[] colores =
    { "MAGENTA", "ROJO", "BLANCO", "AZUL", "CYAN"};
string[] eliminarColores =
    { "ROJO", "BLANCO", "AZUL"};

List<string> lista = new List<string>();

Console.WriteLine($"Capacidad = {lista.Capacity}");

foreach (string color in colores)
    lista.Add(color);

List<string> eliminarLista = 
    new List<string>(eliminarColores);

MostrarInformacion(lista);

EliminarColores(lista, eliminarLista);

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

    if (index != -1)
        Console.WriteLine("La lista contiene AZUL " +
            "en el índice {0}", index);
    else
        Console.WriteLine("La lista no contiene AZUL");
}


void EliminarColores(List<string> lista, 
    List<string> eliminarLista)
{
    foreach (var item in eliminarLista)
    {
        lista.Remove(item);
    }
}