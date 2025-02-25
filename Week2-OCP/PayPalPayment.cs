public class PayPalPayment : IPaymentMethod {
    public void ProcessPayment(double amount) {
        Console.WriteLine($"Processing PayPal payment of ${amount}");
    }
}