LinkedList<int> numeros 
    = new LinkedList<int> ();

foreach (var numero in new int[] { 10, 8, 6, 4, 2, 0})
{
    numeros.AddFirst(numero);
}

Display(numeros);

for (LinkedListNode<int> nodo = numeros.First; 
    nodo != null; nodo = nodo.Next)
{
    Console.WriteLine(nodo.Value);
}

string[] colores = { "negro", "amarillo", "verde",
"azul", "violeta", "plateado"};
string[] colores2 = { "dorado", "blanco",
"café", "azul", "gris"};

LinkedList<string> lista1 = new LinkedList<string> ();

foreach (var color in colores)
{
    lista1.AddLast(color);
}
Display (lista1);

LinkedList<string> lista2 
    = new LinkedList<string>(colores2);
Display (lista2);

Concatenar(lista1, lista2);

void Concatenar<T>(LinkedList<T> lista1, 
    LinkedList<T> lista2)
{
    foreach (T item in lista2)
    {
        lista1.AddLast(item);
    }
}

CadenasAMayusculas(lista1);

void CadenasAMayusculas(LinkedList<string> lista)
{
    LinkedListNode<string> node = lista.First;

    while (node != null)
    {
        string color = node.Value;
        node.Value = color.ToUpper();

        node = node.Next;
    }
}

Display(lista1);

EliminarElementos(lista1, "NEGRO", "CAFÉ");

void EliminarElementos<T>(LinkedList<T> lista, 
    T elementoInicial, T elementoFinal)
{
    LinkedListNode<T> node = lista.Find(elementoInicial);
    LinkedListNode<T> node2 = lista.Find(elementoFinal);

    while ((node.Next != null) &&
        (node.Next != node2))
    {
        lista.Remove(node.Next);
    }
}

Display(lista1);

// tarea: imprima la lista al revés

void Display<T>(LinkedList<T> collection)
{
    foreach (T item in collection)
    {
        Console.Write($"{item}, ");
    }
    Console.WriteLine();
}