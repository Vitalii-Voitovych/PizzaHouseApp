namespace PizzaHouseApp.Models.Entities
{
    public class OrderMenu
    {
        public int OrderMenuId { get; set; }
        
        public int OrderId { get; set; }
        public Order? OrderNavigation { get; set; }

        public int PizzaId { get; set; }
        public Pizza? PizzaNavigation { get; set; }

        public Payment? PaymentNavigation { get; set; }
    }
}
