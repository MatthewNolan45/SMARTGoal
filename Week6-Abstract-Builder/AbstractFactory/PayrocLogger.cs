public class PayrocLogger : ITransactionLogger
{
    public void LogTransaction(string message)
    {
        Console.WriteLine($"[Payroc Logger] {message}");
    }
}
