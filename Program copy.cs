//dependency inversion principle -> soliD

//dependency injections, dependency inversion principle, IoC
//dependency inversion principle talks about the coupling between the different classes or modules
//high-level modules should not depend on low-level modules. Both should depend on abstractions
//Abstractions should not depend on details. Details should depend on abstractions

//constructor injection
//method injection
//property injection
//framework injection

//violating DIP:
class OrderService
{
    private readonly IEmailService _emailService;

    public OrderService(IEmailService emailService)
    {
        _emailService = emailService ??
            throw new ArgumentNullException(nameof(emailService));
    }

    public void PlaceOrder(string product)
    {
        System.Console.WriteLine($"Order placed for {product}");
        _emailService.SendConfirmation(product);
    }
}

public interface IEmailService
{
    void SendConfirmation(string product);
}

class EmailService : IEmailService
{
    public void SendConfirmation(string product)
    {
        System.Console.WriteLine($"Confirmation email sent for {product}");
    }
}

public class MockEmailService : IEmailService
{
    public void SendConfirmation(string product)
    {
        System.Console.WriteLine($"[Mock] Confirmation email sent for {product}");
    }
}

class Program
{
    static void Main()
    {
        IEmailService emailService = new EmailService();
        var orderService = new OrderService(emailService);
        orderService.PlaceOrder("Laptop");

        System.Console.WriteLine();

        IEmailService mockService = new MockEmailService();
        var mockOrderService = new OrderService(mockService);
        mockOrderService.PlaceOrder("Test product");
    }
}