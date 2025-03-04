// Define a minimal interface for processing payments
public interface IPaymentProcessor {
    void ProcessPayment(double amount);
}

// Define a separate interface for payments that support refunds
public interface IRefundablePayment {
    void ProcessRefund(double amount);
}

// Credit Card Payments support both payments and refunds
public class CreditCardPayment : IPaymentProcessor, IRefundablePayment {
    public void ProcessPayment(double amount) {
        Console.WriteLine($"Processing credit card payment of ${amount}");
    }

    public void ProcessRefund(double amount) {
        Console.WriteLine($"Refunding ${amount} to credit card.");
    }
}

// Crypto Payments only support payments, not refunds
public class CryptoPayment : IPaymentProcessor {
    public void ProcessPayment(double amount) {
        Console.WriteLine($"Processing cryptocurrency payment of ${amount}");
    }
}

// PaymentProcessor only cares about processing payments
public class PaymentProcessor {
    public void ProcessPayment(IPaymentProcessor paymentMethod, double amount) {
        paymentMethod.ProcessPayment(amount);
    }
}

// RefundProcessor only works with payments that support refunds
public class RefundProcessor {
    public void ProcessRefund(IRefundablePayment refundablePayment, double amount) {
        refundablePayment.ProcessRefund(amount);
    }
}

// ✅ Now, we can process payments and refunds properly!
var paymentProcessor = new PaymentProcessor();
var refundProcessor = new RefundProcessor();

var creditCardPayment = new CreditCardPayment();
var cryptoPayment = new CryptoPayment();

paymentProcessor.ProcessPayment(creditCardPayment, 100);  // Works
paymentProcessor.ProcessPayment(cryptoPayment, 50);       // Works
refundProcessor.ProcessRefund(creditCardPayment, 50);     // Works
// refundProcessor.ProcessRefund(cryptoPayment, 50);     ❌ Compilation Error! CryptoPayment doesn't support refunds
