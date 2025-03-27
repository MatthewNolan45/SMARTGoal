using System;

// Interface defining the contract for payment methods
public interface IPaymentMethod
{
    // Method to process a payment
    void ProcessPayment(decimal amount);
}

// Class implementing payment via credit card
public class CreditCardPayment : IPaymentMethod
{
    public void ProcessPayment(decimal amount)
    {
        // Simulate processing a credit card payment
        Console.WriteLine($"Processing credit card payment of {amount:C}");
    }
}

// Class implementing payment via PayPal
public class PayPalPayment : IPaymentMethod
{
    public void ProcessPayment(decimal amount)
    {
        // Simulate processing a PayPal payment
        Console.WriteLine($"Processing PayPal payment of {amount:C}");
    }
}

// Class implementing payment via bank transfer
public class BankTransferPayment : IPaymentMethod
{
    public void ProcessPayment(decimal amount)
    {
        // Simulate processing a bank transfer payment
        Console.WriteLine($"Processing bank transfer payment of {amount:C}");
    }
}

// Factory class to create instances of payment methods
public class PaymentFactory
{
    // Static method to create a payment method based on the provided type
    public static IPaymentMethod CreatePaymentMethod(string type)
    {
        // Use a switch expression to return the appropriate payment method
        return type switch
        {
            "CreditCard" => new CreditCardPayment(), // Create a CreditCardPayment instance
            "PayPal" => new PayPalPayment(),         // Create a PayPalPayment instance
            "BankTransfer" => new BankTransferPayment(), // Create a BankTransferPayment instance
            _ => throw new ArgumentException("Invalid payment method type") // Handle invalid types
        };
    }
}

// Main program class containing the entry point of the application
public class Program
{
    public static void Main(string[] args)
    {
        // Create and use a CreditCardPayment instance
        IPaymentMethod paymentMethod = PaymentFactory.CreatePaymentMethod("CreditCard");
        paymentMethod.ProcessPayment(100.00m); // Process a payment of $100.00

        // Create and use a PayPalPayment instance
        paymentMethod = PaymentFactory.CreatePaymentMethod("PayPal");
        paymentMethod.ProcessPayment(200.00m); // Process a payment of $200.00

        // Create and use a BankTransferPayment instance
        paymentMethod = PaymentFactory.CreatePaymentMethod("BankTransfer");
        paymentMethod.ProcessPayment(300.00m); // Process a payment of $300.00
    }
}