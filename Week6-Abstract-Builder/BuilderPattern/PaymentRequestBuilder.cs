public class PaymentRequestBuilder : IPaymentRequestBuilder
{
    private PaymentRequest _request = new();

    public void SetAmount(decimal amount)
    {
        _request.Amount = amount;
    }

    public void AddDiscount(decimal discount)
    {
        _request.Discount = discount;
    }

    public void AddTax(decimal tax)
    {
        _request.Tax = tax;
    }

    public void AddMetadata(string key, string value)
    {
        _request.Metadata[key] = value;
    }

    public PaymentRequest Build()
    {
        return _request;
    }
}
