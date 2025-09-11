namespace AAA;

class Program
{
    static void Main()
    {
        MyStack stack = new MyStack(5);
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);
   
        Console.WriteLine("Current stack");
        for (int i = stack.top; i >= 0; i--)
        {
            Console.WriteLine(stack.stackArray[i]);
        }
 
        try
        {
            Console.WriteLine("Popped value: " + stack.Pop());
            Console.WriteLine("Peeked value: " + stack.Peek());
            Console.WriteLine("Popped value: " + stack.Pop());
            Console.WriteLine("Popped value: " + stack.Pop());
            Console.WriteLine("Peeked value: " + stack.Peek());
            Console.WriteLine("Popped value: " + stack.Pop());
            Console.WriteLine("Popped value: " + stack.Pop());
            Console.WriteLine("Peeked value: " + stack.Peek());
            Console.WriteLine("Popped value: " + stack.Pop());
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine(e.Message);
        }
 
        Console.WriteLine("Current stack");
        for (int i = stack.top; i >= 0; i--)
        {
            Console.WriteLine(stack.stackArray[i]);
        }
 
    }
}
 
public class MyStack
{
    public int[] stackArray;
    public int top;
 
    public MyStack(int size)
    {
        stackArray = new int[size];
        top = -1;
    }
 
    public void Push(int value)
    {
        if (top == stackArray.Length - 1)
        {
            throw new InvalidOperationException("Stack overvflow");
        }
        stackArray[++top] = value;
    }
 
    public int Pop()
    {
        if (top == -1)
        {
            throw new InvalidOperationException("Stack undervflow");
        }
        return stackArray[top--];
    }
 
    public int Peek()
    {
        if (top == -1)
        {
            throw new InvalidOperationException("Stack undervflow");
        }
        return stackArray[top];
    }
}