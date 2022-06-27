namespace OrderProcessingSystemDotnet.Models.Tables
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string? OrderDate { get; set; }
        public string? RequiredDate { get; set; }
        public string? ShippedDate { get; set; }
        public int? Status { get; set; }
        public string? Comments { get; set; }
    }
}
