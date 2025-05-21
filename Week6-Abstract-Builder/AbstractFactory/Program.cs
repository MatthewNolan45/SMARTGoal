class Program
{
    static void Main()
    {
        ProcessPayment(new PayrocFactory(), 150.00m);
    }

    static void ProcessPayment(IPaymentGatewayFactory factory, decimal amount)
    {
        var processor = factory.CreatePaymentProcessor();
        var logger = factory.CreateTransactionLogger();

        processor.ProcessPayment(amount);
        logger.LogTransaction($"Payment of €{amount} processed successfully.");
    }
}
