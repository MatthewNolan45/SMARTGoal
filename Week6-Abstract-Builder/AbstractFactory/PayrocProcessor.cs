public class PayrocProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"[Payroc] Processing payment of €{amount}");
    }
}
