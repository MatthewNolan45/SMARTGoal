class Program
{
    static void Main()
    {
        var builder = new PaymentRequestBuilder();
        var director = new PaymentRequestDirector(builder);

        director.ConstructDiscountedPayment(100.00m, 10.00m);
        builder.AddMetadata("CustomerId", "C12345");
        builder.AddMetadata("OrderId", "O98765");

        var request = builder.Build();
        Console.WriteLine(request);
    }
}
