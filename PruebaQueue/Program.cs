using Modelo;

Queue<Punto> puntos = new Queue<Punto>();

puntos.Enqueue(new Punto(3, 7));
puntos.Enqueue(new Punto(7, 9));
puntos.Enqueue(new Punto(11, 2));

Display(puntos);

Console.WriteLine("------------");

// Hacemos Peek
Console.WriteLine("Peek {0}", puntos.Peek());

Display(puntos);

// Hacemos dequeue
Console.WriteLine("Dequeue {0}", 
    puntos.Dequeue());
Console.WriteLine("Dequeue {0}",
    puntos.Dequeue());

Display(puntos);

void Display(Queue<Punto> puntos)
{
    foreach (var punto in puntos)
        Console.WriteLine("->{0}", punto);
}
