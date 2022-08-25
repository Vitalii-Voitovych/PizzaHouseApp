namespace PizzaHouseApp.Models.Entities
{
    public class Payment
    {
        public int PaymentId { get; set; }

        public int OrderMenuId { get; set; }
        public OrderMenu? OrderMenuNavigation { get; set; }

        public DateTime PaymentDate { get; set; }
    }
}
