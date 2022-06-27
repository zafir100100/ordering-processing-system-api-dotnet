namespace OrderProcessingSystemDotnet.Models.Tables
{
    public class Product
    {
        public int Id { get; set; }
        public int ProductLineId { get; set; }
        public string? Name { get; set; }
        public string? Scale { get; set; }
        public string? Vendor { get; set; }
        public string? PdtDescription { get; set; }
        public string? QtyInStock { get; set; }
        public string? BuyPrice { get; set; }
        public string? MSRP { get; set; } // Manufacturer's Suggested Retail Price
    }
}
