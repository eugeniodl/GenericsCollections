
using Modelo;

Student st1 = new(1, "Pedro", "López",
    18);
Student st2 = new(2, "Susana", "Pérez",
    20);
Student st3 = new(3, "Roberto", "Zapata",
    17);
Student st4 = new(4, "Andrés", "Espinoza",
    19);

Dictionary<int, Student> students =
    new Dictionary<int, Student>();

students.Add(st1.Id, st1);
students.Add(st2.Id, st2);
students.Add(st3.Id, st3);
students.Add(st4.Id, st4);

foreach (var item in students.Values)
{
    Console.WriteLine("Nombre: {0};" +
        "Edad: {1}", item.Name, item.Age);
}