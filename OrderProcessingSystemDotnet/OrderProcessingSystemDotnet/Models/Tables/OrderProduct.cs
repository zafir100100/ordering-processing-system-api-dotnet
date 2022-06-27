namespace OrderProcessingSystemDotnet.Models.Tables
{
    public class OrderProduct
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int? Qty { get; set; }
        public decimal? PriceEach { get; set; }
    }
}
