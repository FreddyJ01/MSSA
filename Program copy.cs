namespace AAA;
//stacks and queues using system.collections.generic
class Program
{
    static void Main(string[] args)
    {
        Stack<int> numbers = new Stack<int>();
        numbers.Push(10);
        numbers.Push(8);
        numbers.Pop();
        numbers.Clear();
        numbers.Push(1);

        System.Console.WriteLine(numbers);

        Queue<string> queueNames = new Queue<string>();

        queueNames.Enqueue("Apple");
        queueNames.Enqueue("Mango");
        queueNames.Enqueue("Banana");

        System.Console.WriteLine(queueNames.Count());

        queueNames.Dequeue();
    }
}