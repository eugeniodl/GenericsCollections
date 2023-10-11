using Modelo;

Queue<Punto> puntos = new Queue<Punto>();

puntos.Enqueue(new Punto(3, 7));
puntos.Enqueue(new Punto(7, 9));
puntos.Enqueue(new Punto(11, 2));
puntos.Enqueue(new Punto(5, 8));

Imprimir(puntos);

void Imprimir<T>(Queue<T> collection)
{
    foreach (T item in collection)
    {
        Console.Write($"{item} ");
        Console.Write(item + " ");
        Console.Write("{0} ", item);
    }
}

