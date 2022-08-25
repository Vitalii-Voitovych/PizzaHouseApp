namespace PizzaHouseApp.Models.Entities
{
    public class Order
    {
        public int OrderId { get; set; }

        public int CustomerId { get; set; }
        public Customer? CustomerNavigation { get; set; }

        public DateTime OrderDate { get; set; }

        public IEnumerable<Payment> Payments { get; set; } = new List<Payment>();
    }
}
