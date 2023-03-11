namespace FastFood.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime OrderDate { get; set; }
        public Product Product { get; set; }
        public Employee Employee { get; set; }
    }
}
