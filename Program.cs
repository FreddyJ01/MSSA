//interface seggregation principle -> solId

/*do not do this:
public interface IWorker
{
    void Work();
    void Eat();
}
*/

//correct way to increase independency
public interface IWork
{
    void Work();
}

public interface IEat
{
    void Eat();
}
public class Robot : IWork
{
    public void Work() => System.Console.WriteLine("Robot is working");
}

public class Human : IWork, IEat
{
    public void Work() => System.Console.WriteLine("Human is working");
    public void Eat() => throw new NotImplementedException();
}

public class DogWalker : IWork, IEat {
    public void Work() => System.Console.WriteLine("Dog walker is working");
    public void Eat() => throw new NotImplementedException();
}

class Program
{
    static void Main()
    {
        IWork worker = new Robot();
        worker.Work();
    }
}