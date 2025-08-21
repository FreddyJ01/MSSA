namespace StackDemo;

class Program
{
    static void Main(string[] Args)
    {
        Stack stack = new Stack(5);
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        System.Console.WriteLine(stack.Peek());
        System.Console.WriteLine(stack.Pop());
        System.Console.WriteLine(stack.Pop());
        System.Console.WriteLine(stack.Pop());
        stack.Push(17);
        System.Console.WriteLine(stack.Pop());

        string text = "Hello";
        System.Console.WriteLine(text);
        Stack<char> stack = new Stack<char>();

        foreach (char c in text)
        {
            stack.Push(c);
        }

        while (stack.Count > 0)
            System.Console.Write(stack.Pop());
    }

}

class Stack
{
    int[] items;
    int top;

    public Stack(int size)
    {
        items = new int[size];
        top = -1;
    }

    public void Push(int value)
    {
        items[++top] = value;
    }

    public int Pop()
    {
        return items[top--];
    }

    public int Peek()
    {
        return items[top];
    }

    public bool isEmpty()
    {
        return top == -1;
    }
}