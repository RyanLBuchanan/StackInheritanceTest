using StackInheritanceLibrary;
using LinkedListLibrary;

namespace StackInheritanceTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackInheritance stack = new StackInheritance();

            // Create objects to store in the stack
            bool aBoolean = true;
            char aCharacter = '$';
            int anInteger = 34567;
            string aString = "hello";

            // Use method Push to add items to the stack
            stack.Push(aBoolean);
            stack.Display();
            stack.Push(aCharacter);
            stack.Display();
            stack.Push(anInteger);
            stack.Display();
            stack.Push(aString);
            stack.Display();

            // Remove items from stack
            try
            {
                while (true)
                {
                    object removedObject = stack.Pop();
                    Console.WriteLine($"{removedObject} popped\n");
                }
            }
            catch (EmptyListException emptyListException)
            {
                // If exception occurs, write stack trace here
                Console.Error.WriteLine(emptyListException.StackTrace);
            }
        }
    }
}