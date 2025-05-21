
public class PayrocFactory : IPaymentGatewayFactory
{
    public IPaymentProcessor CreatePaymentProcessor() => new PayrocProcessor();
    public ITransactionLogger CreateTransactionLogger() => new PayrocLogger();
}
