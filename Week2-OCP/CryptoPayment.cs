public class CryptoPayment : IPaymentMethod {
    public void ProcessPayment(double amount) {
        Console.WriteLine($"Processing cryptocurrency payment of ${amount}");
    }
}