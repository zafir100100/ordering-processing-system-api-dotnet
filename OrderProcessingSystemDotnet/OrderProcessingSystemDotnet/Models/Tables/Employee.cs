namespace OrderProcessingSystemDotnet.Models.Tables
{
    public class Employee
    {
        public int Id { get; set; }
        public int? OfficeId { get; set; }
        public int? ReportsTo { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? Extension { get; set; }
        public string? Email { get; set; }
        public string? JobTitle { get; set; }
    }
}
