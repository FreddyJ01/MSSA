namespace QueueDemo;

class Program
{
    static void Main(string[] Args)
    {
        Queue customerQueue = new Queue();
        customerQueue.Enqueue("Alice");
        customerQueue.Enqueue("Bob");
        customerQueue.Enqueue("Charlie");

        foreach (var customer in customerQueue)
        {
            System.Console.WriteLine($"Customer: {customer}");
        }
    }
}