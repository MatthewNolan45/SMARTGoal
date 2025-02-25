public class PaymentProcessor {
    public void ProcessPayment(IPaymentMethod paymentMethod, double amount) {
        paymentMethod.ProcessPayment(amount);
    }
}