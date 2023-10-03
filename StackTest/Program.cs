// create arrays of doubles and ints
using StackTest;

double[] doubleElements =
    { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6 };
int[] intElements =
    { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

StackTest.Stack<double> doubleStack = new(5); // stack stores doubles
StackTest.Stack<int> intStack = new(10); // stack of ints

TestPushDouble(); // push double onto doubleStack

// test Push method with doubleStack
void TestPushDouble()
{
    try
    {
        // push elements onto stack
        Console.WriteLine("\nPushing elements onto doubleStack");

        foreach (var element in doubleElements)
        {
            Console.Write($"{element:F1} ");
            doubleStack.Push(element); // push onto doubleStack
        }
    }
    catch (FullStackException exception)
    {
        Console.Error.WriteLine($"\nMessage: {exception.Message}");
        Console.Error.WriteLine(exception.StackTrace);
    }
}