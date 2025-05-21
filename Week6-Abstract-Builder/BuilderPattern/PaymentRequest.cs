public class PaymentRequest
{
    public decimal Amount { get; set; }
    public decimal Discount { get; set; }
    public decimal Tax { get; set; }
    public Dictionary<string, string> Metadata { get; set; } = new();

    public override string ToString()
    {
        return $"Amount: €{Amount}, Discount: €{Discount}, Tax: €{Tax}, Metadata: [{string.Join(", ", Metadata.Select(kv => $"{kv.Key}={kv.Value}"))}]";
    }
}
