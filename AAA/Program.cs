namespace AAA;

class Program
{
    static void Main(string[] Args)
    {
        DoubleEndedQueue myQueue = new DoubleEndedQueue(5);
        try
        {
            myQueue.EnqueueFront(1);
            System.Console.WriteLine($"Front: {myQueue.front}, Rear: {myQueue.rear}");
            myQueue.EnqueueFront(2);
            System.Console.WriteLine($"Front: {myQueue.front}, Rear: {myQueue.rear}");
            myQueue.Display();
            System.Console.WriteLine($"Front: {myQueue.front}, Rear: {myQueue.rear}");

            myQueue.EnqueueRear(3);
            System.Console.WriteLine($"Front: {myQueue.front}, Rear: {myQueue.rear}");
            myQueue.EnqueueRear(4);
            System.Console.WriteLine($"Front: {myQueue.front}, Rear: {myQueue.rear}");
            myQueue.Display();
            System.Console.WriteLine($"Front: {myQueue.front}, Rear: {myQueue.rear}");

            System.Console.WriteLine($"Dequeue Rear: {myQueue.DequeueRear()}");
            System.Console.WriteLine($"Dequeue Front: {myQueue.DequeueFront()}");
            myQueue.Display();
            System.Console.WriteLine($"Dequeue Rear: {myQueue.DequeueRear()}");
            System.Console.WriteLine($"Dequeue Front: {myQueue.DequeueFront()}");
            myQueue.Display();
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
        }
    }
}

class DoubleEndedQueue
{
    private int[] queue;
    public int front, rear, _capacity;

    public DoubleEndedQueue(int capacity)
    {
        queue = new int[capacity];
        front = -1;
        rear = -1;
        _capacity = capacity;
    }

    public void EnqueueFront(int value)
    {
        //check if queue is full
        if (front == 0 ? (queue.Length - 1 == rear) : (front - 1) % _capacity == rear)
        {
            throw new InvalidOperationException("Queue Overflow");
        }
        //check if queue is being used first time
        if (front == -1)
        {
            front = 0;
            rear = 0;
        }
        //if front is 0 wrap around the rear of the queue
        else if (front == 0)
        {
            front = _capacity - 1;
        }
        //if front is not 0 check the previous index
        else
        {
            front--;
        }

        //add value to the front of queue
        queue[front] = value;
    }

    public void EnqueueRear(int value)
    {
        if ((rear + 1) % _capacity == front)
        {
            throw new InvalidOperationException("Queue Overflow");
        }
        if (front == -1) front = 0;

        rear = (rear + 1) % _capacity;

        queue[rear] = value;
    }

    public int DequeueFront()
    {
        //check if empty
        if (front == -1)
        {
            throw new InvalidOperationException("Empty Queue");
        }
        
        //grab value at front for return
        int temp = queue[front];
        
        //remove value from queue and iterate
        queue[front] = default;

        //reset queue if only one element
        if (front == rear)
        {
            front = -1;
            rear = -1;
            return temp;
        }
        
        //iterate front
        front = (front + 1) % _capacity;
        
        //return the value
        return temp;
    }

    public int DequeueRear() //front: 4 rear: 2
    {
        //check if empty
        if (front == -1)
        {
            throw new InvalidOperationException("Empty Queue");
        }
        
        //grab value at rear for return
        int temp = queue[rear]; //temp: 4

        //remove value from queue and iterate
        queue[rear] = default;

        //reset queue if only one element
        if (front == rear)
        {
            front = -1;
            rear = -1;
            return temp;
        }
        
        //iterate rear
        rear = rear == 0 ? _capacity - 1 : (rear - 1) % _capacity;
        
        //return the value
        return temp;
    }

    public void Display()
    {
        foreach (int num in queue)
        {
            System.Console.Write(num + " ");
        }
        System.Console.WriteLine();
    }
}