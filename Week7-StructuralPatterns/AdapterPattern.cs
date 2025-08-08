public interface IPaymentProcessor {
    void ProcessPayment(double amount);
}

// Adapter converts your system calls to third-party calls
public class ExternalPaymentAdapter : IPaymentProcessor {
    private readonly ExternalPaymentAPI _externalPaymentAPI;

    public ExternalPaymentAdapter(ExternalPaymentAPI externalPaymentAPI) {
        _externalPaymentAPI = externalPaymentAPI;
    }

    public void ProcessPayment(double amount) {
        // Convert double to decimal if needed
        _externalPaymentAPI.MakePayment((decimal)amount);
    }
}


//var externalAPI = new ExternalPaymentAPI();
//IPaymentProcessor processor = new ExternalPaymentAdapter(externalAPI);
//processor.ProcessPayment(75.50);
