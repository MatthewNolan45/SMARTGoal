public class PaymentProcessor
{
    public virtual void ProcessPayment(decimal amount)
    {
        // Base payment processing logic
    }
}

public class CreditCardProcessor : PaymentProcessor
{
    public override void ProcessPayment(decimal amount)
    {
        if (amount > 1000)
        {
            throw new InvalidOperationException("Credit card payments cannot exceed $1000.");
        }
        // Credit card payment processing logic
    }
}