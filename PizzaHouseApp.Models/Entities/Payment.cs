namespace PizzaHouseApp.Models.Entities
{
    public class Payment
    {
        public int PaymentId { get; set; }

        public int OrderId { get; set; }
        public Order? Order { get; set; }

        public int PizzaId { get; set; }
        public Pizza? Pizza { get; set; }

        public DateTime PaymentDate { get; set; }
    }
}
