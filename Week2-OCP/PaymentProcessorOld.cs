public class PaymentProcessor {
    public void ProcessPayment(string paymentType, double amount) {
        if (paymentType == "CreditCard") {
            // Process credit card payment
            Console.WriteLine($"Processing credit card payment of ${amount}");
        } else if (paymentType == "PayPal") {
            // Process PayPal payment
            Console.WriteLine($"Processing PayPal payment of ${amount}");
        } else if (paymentType == "Crypto") {
            // Process cryptocurrency payment
            Console.WriteLine($"Processing cryptocurrency payment of ${amount}");
        } else {
            throw new ArgumentException("Unsupported payment type");
        }
    }
}