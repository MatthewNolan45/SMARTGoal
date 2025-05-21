public class PaymentRequestDirector
{
    private readonly IPaymentRequestBuilder _builder;

    public PaymentRequestDirector(IPaymentRequestBuilder builder)
    {
        _builder = builder;
    }

    public void ConstructStandardPayment(decimal amount)
    {
        _builder.SetAmount(amount);
        _builder.AddTax(amount * 0.2m); // 20% tax
    }

    public void ConstructDiscountedPayment(decimal amount, decimal discount)
    {
        _builder.SetAmount(amount);
        _builder.AddDiscount(discount);
        _builder.AddTax((amount - discount) * 0.2m);
    }
}
