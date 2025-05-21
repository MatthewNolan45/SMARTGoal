public interface IPaymentRequestBuilder
{
    void SetAmount(decimal amount);
    void AddDiscount(decimal discount);
    void AddTax(decimal tax);
    void AddMetadata(string key, string value);
    PaymentRequest Build();
}
