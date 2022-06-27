namespace OrderProcessingSystemDotnet.Models.Tables
{
    public class Payment
    {
        public string? CheckNum { get; set; }
        public int CustomerId { get; set; }
        public DateTime? PaymentDate { get; set; }
        public decimal? Amount { get; set; }
    }
}
