namespace MSSA.Demos;

class Program
{
    static void Main(string[] Args)
    {
        CircularQueue cq = new CircularQueue(5);
        try
        {
            cq.Enqueue(10);
            cq.Enqueue(20);
            cq.Enqueue(30);
            cq.Enqueue(40);
            cq.Display();
            System.Console.WriteLine("Dequeued: " + cq.Dequeue());
            cq.Display();
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
        }
    }
}

class CircularQueue
{
    private int[] queue;
    private int front, rear, size;

    public CircularQueue(int capacity)
    {
        queue = new int[capacity];
        front = -1;
        rear = -1;
        size = capacity;
    }

    public void Enqueue(int value)
    {
        //is the rear right behind the front?
        if ((rear + 1) % size == front)
        {
            throw new InvalidOperationException("Queue Overflow");
        }
        
        //checks to make sure the queue is not being used for first time
        if (front == -1) front = 0;
        
        //iterates the rear pointer
        rear = (rear + 1) % size;

        //add value to the rear of the queue
        queue[rear] = value;
    }

    public int Dequeue()
    {
        //ensure there is at least one element in the queue
        if (front == -1)
        {
            throw new InvalidOperationException("Empty Queue");
        }

        //store front element from queue for return
        int value = queue[front];

        if (front == rear)
        {
            front = -1;
            rear = -1;
        }
        else front = (front + 1) % size;
        return value;
    }

    public void Display()
    {
        if (front == -1)
        {
            throw new InvalidOperationException("Empty Queue");
        }
        int i = front;
        do
        {
            System.Console.Write(queue[i] + " ");
            i = (i + 1) % size;
        } while (i != (rear + 1) % size);
        Console.WriteLine();
    }
}