Console.WriteLine($"Maximum of 3, 4 and 5 is {Maximum(3, 4, 5)}\n");
Console.WriteLine($"Maximum of 6.6, 8.8 and 7.7 is " +
    $"{Maximum(6.6, 8.8, 7.7)}\n");
Console.WriteLine($"Maximum of pear, apple and orange is " +
    $"{Maximum("pear", "apple", "orange")}\n");

// generic function determines the
// largest of the IComparable<T> objects
T Maximum<T>(T v1, T v2, T v3) where T : IComparable<T>
{
    var max = v1; // assume v1 is initially the largest

    // compare v2 with max
    if(v2.CompareTo(max) > 0)
    {
        max = v2; // v2 is the largest so far
    }

    // compare v3 with max
    if(v3.CompareTo(max) > 0)
    {
        max = v3; // v3 is the largest
    }

    return max; // return largest object
} 