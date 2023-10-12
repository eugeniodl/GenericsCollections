using Modelo;

Queue<Punto> puntos = new Queue<Punto>(); // FIFO
puntos.Enqueue(new Punto(3, 7));
puntos.Enqueue(new Punto(7, 9));
puntos.Enqueue(new Punto(11, 2));
puntos.Enqueue(new Punto(5, 8));

Imprimir(puntos);

Console.WriteLine("Dequeue {0}", puntos.Dequeue());
Console.WriteLine("Dequeue {0}", puntos.Dequeue());

Imprimir(puntos);

Console.WriteLine("Peek {0}", puntos.Peek());

Imprimir(puntos);

// Conteo de los objetos
Console.WriteLine(puntos.Count);

Punto p = new Punto(10, 7);

// Verificamos si existe el elemento
Console.WriteLine(puntos.Contains(p));

void Imprimir<T>(Queue<T> collection)
{
    foreach (T item in collection)
    {
        Console.Write($"{item}; ");
        //Console.Write(item + " ");
        //Console.Write("{0} ", item);
    }
    Console.WriteLine();
}

