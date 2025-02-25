// The PaymentProcessor class is an abstract base class that defines the contract for processing payments.
// This ensures that all derived classes must implement the ProcessPayment method.
public abstract class PaymentProcessor
{
    public abstract void ProcessPayment(decimal amount);
}

// The CreditCardProcessor class is a subclass of PaymentProcessor.
// It adheres to LSP by ensuring that it can be used wherever PaymentProcessor is expected without causing unexpected behavior.
public class CreditCardProcessor : PaymentProcessor
{
    private const decimal MaxCreditCardAmount = 1000;

    // The ProcessPayment method in CreditCardProcessor includes specific validation logic for credit card payments.
    // This ensures that the behavior is consistent with the expectations set by the PaymentProcessor base class.
    public override void ProcessPayment(decimal amount)
    {
        if (amount > MaxCreditCardAmount)
        {
            throw new InvalidOperationException($"Credit card payments cannot exceed ${MaxCreditCardAmount}.");
        }
        // Credit card payment processing logic
    }
}

// The PayPalProcessor class is another subclass of PaymentProcessor.
// It also adheres to LSP by implementing the ProcessPayment method in a way that is consistent with the base class.
public class PayPalProcessor : PaymentProcessor
{
    public override void ProcessPayment(decimal amount)
    {
        // PayPal payment processing logic
    }
}