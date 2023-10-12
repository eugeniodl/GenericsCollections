using Modelo;

Stack<Punto> puntos = new Stack<Punto>();
puntos.Push(new Punto(3, 4));
puntos.Push(new Punto(5, 7));
puntos.Push(new Punto(9, 11));
puntos.Push(new Punto(1, 4));

Imprimir(puntos);

Console.WriteLine("Pop {0}", puntos.Pop());

Imprimir(puntos);

Console.WriteLine("Peek {0}", puntos.Peek());

Imprimir(puntos);

void Imprimir(Stack<Punto> puntos)
{
    foreach (var item in puntos)
    {
        Console.Write($"{item}; ");
    }
    Console.WriteLine();
}