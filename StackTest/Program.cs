// create arrays of doubles and ints
using StackTest;

double[] doubleElements =
    { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6};
int[] intElements =
    { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11};

StackTest.Stack<double> doubleStack = new(5); // stack of doubles
StackTest.Stack<int> intStack = new(10); // stack of ints

TestPushDouble(); // push double onto doubleStack

// test Push method with doubleStack
void TestPushDouble()
{
    try
    {
        Console.WriteLine("\nPushing elements onto doubleStack");

        // push elements onto stack
        foreach (var element in doubleElements)
        {
            Console.WriteLine($"{element:F1} ");
            doubleStack.Push(element); // push onto doubleStack
        }
    }
    catch (FullStackException exception)
    {
        Console.Error.WriteLine($"\nMessage: {exception.Message}");
        Console.Error.WriteLine(exception.StackTrace);
    }
}