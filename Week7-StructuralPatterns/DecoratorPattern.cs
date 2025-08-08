public interface IPaymentProcessor {
    void ProcessPayment(double amount);
}

public class CreditCardPaymentProcessor : IPaymentProcessor {
    public void ProcessPayment(double amount) {
        Console.WriteLine($"Processing credit card payment of ${amount}");
    }
}

public abstract class PaymentProcessorDecorator : IPaymentProcessor {
    protected readonly IPaymentProcessor _wrappedProcessor;

    public PaymentProcessorDecorator(IPaymentProcessor processor) {
        _wrappedProcessor = processor;
    }

    public virtual void ProcessPayment(double amount) {
        _wrappedProcessor.ProcessPayment(amount);
    }
}

public class FraudCheckDecorator : PaymentProcessorDecorator {
    public FraudCheckDecorator(IPaymentProcessor processor) : base(processor) { }

    public override void ProcessPayment(double amount) {
        Console.WriteLine("Running fraud check...");
        base.ProcessPayment(amount);
    }
}

public class LoggingDecorator : PaymentProcessorDecorator {
    public LoggingDecorator(IPaymentProcessor processor) : base(processor) { }

    public override void ProcessPayment(double amount) {
        Console.WriteLine($"[LOG] Payment started at {DateTime.Now}");
        base.ProcessPayment(amount);
        Console.WriteLine($"[LOG] Payment finished at {DateTime.Now}");
    }
}

// IPaymentProcessor processor = new CreditCardPaymentProcessor();
// processor = new FraudCheckDecorator(processor);
// processor = new LoggingDecorator(processor);

// processor.ProcessPayment(200);
