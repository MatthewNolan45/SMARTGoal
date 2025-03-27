// The PaymentGateway class implements the Singleton design pattern
public class PaymentGateway
{
    // Static field to hold the single instance of the class
    private static PaymentGateway _instance;

    // Object used for thread-safety when creating the instance
    private static readonly object _lock = new object();

    // Private constructor to prevent instantiation from outside the class
    private PaymentGateway() { }

    // Public property to provide access to the single instance
    public static PaymentGateway Instance
    {
        get
        {
            // Lock ensures thread-safe access to the instance
            lock (_lock)
            {
                // If the instance does not exist, create it
                if (_instance == null)
                {
                    _instance = new PaymentGateway();
                }
                // Return the single instance
                return _instance;
            }
        }
    }

    // Method to simulate processing a payment
    public void ProcessPayment(decimal amount, string payerName)
    {
        // Output the payment details to the console
        Console.WriteLine($"Processing payment of {amount:C} from {payerName}");
        // Payment processing logic would go here
    }
}

// The Program class contains the Main method, the entry point of the application
public class Program
{
    public static void Main()
    {
        // Accessing the singleton instance of PaymentGateway
        PaymentGateway gateway = PaymentGateway.Instance;

        // Using the singleton instance to process payments
        gateway.ProcessPayment(100.50m, "John Doe"); // Example payment 1
        gateway.ProcessPayment(75.25m, "Jane Smith"); // Example payment 2
    }
}