public interface IPaymentGatewayFactory
{ 
    IPaymentProcessor CreatePaymentProcessor();
    ITransactionLogger CreateTransactionLogger();
}
