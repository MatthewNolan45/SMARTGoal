public interface IPaymentProcessor {
    void ProcessPayment(double amount);
    void ProcessRefund(double amount); // 🚨 Not all payments support refunds!
}

public class CreditCardPayment : IPaymentProcessor {
    public void ProcessPayment(double amount) {
        Console.WriteLine($"Processing credit card payment of ${amount}");
    }

    public void ProcessRefund(double amount) {
        Console.WriteLine($"Refunding ${amount} to credit card.");
    }
}

// 🚨 Crypto payments do NOT support refunds, but are forced to implement ProcessRefund
public class CryptoPayment : IPaymentProcessor {
    public void ProcessPayment(double amount) {
        Console.WriteLine($"Processing cryptocurrency payment of ${amount}");
    }

    public void ProcessRefund(double amount) {
        throw new NotImplementedException("Refunds are not supported for crypto payments.");
    }
}
