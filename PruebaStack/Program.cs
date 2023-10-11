using Modelo;

Stack<Punto> puntos = new Stack<Punto>();
puntos.Push(new Punto(3, 4));
puntos.Push(new Punto(5, 7));
puntos.Push(new Punto(9, 11));
puntos.Push(new Punto(1, 4));

Display(puntos);

Console.WriteLine("Peek {0}", 
    puntos.Peek());

Console.WriteLine("Pop {0}", 
    puntos.Pop());
Console.WriteLine("Pop {0}",
    puntos.Pop());

Display(puntos);

void Display(Stack<Punto> puntos)
{
    foreach (var p in puntos)
    {
        Console.WriteLine("->{0}", p);
    }
    Console.WriteLine("---------------");
}