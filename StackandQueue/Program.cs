namespace StackandQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure using Stack And Queue");
            Console.WriteLine("Create Stack using Linked List");
            LinkedListStack stack = new LinkedListStack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();

            stack.Peek();
            stack.Pop();
            stack.IsEmpty();
            stack.Display();
        }
    }
}