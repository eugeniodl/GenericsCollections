LinkedList<int> numeros =
    new LinkedList<int> ();

foreach(int numero in 
    new int[] { 10, 8, 6, 4, 2, 0})
    numeros.AddFirst (numero);

foreach (var numero in numeros)
{
    Console.WriteLine(numero);
}

numeros.Remove(6);

Console.WriteLine("----------------");

LinkedListNode<int> nodoImportante =
    new LinkedListNode<int>(15);
numeros.AddLast (nodoImportante);

for (LinkedListNode<int> nodo = numeros.First; 
    nodo != null; nodo = nodo.Next)
{
    Console.WriteLine(nodo.Value);
}

string[] colores = { "negro", "amarillo", 
"verde", "azul", "violeta", "plateado"};
string[] colores2 = { "dorado", "blanco",
"café", "azul", "gris"};

// agregue elementos del arreglo colores a una
// lista enlazada
LinkedList<string> lista1 = new LinkedList<string> ();

foreach (var color in colores)
{
    lista1.AddLast(color);
}

LinkedList<string> lista2 = 
    new LinkedList<string>(colores2);

// concatene lista2 en lista1
Concatenar(lista1, lista2);

void Concatenar<T>(LinkedList<T> lista1, 
    LinkedList<T> lista2)
{
    foreach (T valor in lista2)
    {
        lista1.AddLast(valor);
    }
}

// convertir los elementos de lista1 a mayúscula
CadenasAMayusculas(lista1);

void CadenasAMayusculas(LinkedList<string> lista)
{
    LinkedListNode<string> nodo = lista.First;

    while(nodo != null)
    {
        string color = nodo.Value;
        nodo.Value = color.ToUpper();

        nodo = nodo.Next;
    }
}

Imprimir(lista1);

void Imprimir<T>(LinkedList<T> lista)
{
    foreach (T valor in lista)
    {
        Console.Write($"{valor} ");
    }
    Console.WriteLine("----------------");
}