SortedList<int, string> automoviles =
    new SortedList<int, string>();

automoviles.Add(754, "Honda");
automoviles.Add(123, "Tesla");
automoviles.Add(587, "Mitsubishi");
automoviles.Add(323, "Ford");

foreach (var item in automoviles)
{
    Console.WriteLine("({0}, {1})", item.Key, item.Value);
}

Console.WriteLine("----------------------");

Console.WriteLine(automoviles.Count);

Console.WriteLine(automoviles.ContainsKey(123));
Console.WriteLine(automoviles.ContainsValue("Honda"));

Console.WriteLine("------------");
