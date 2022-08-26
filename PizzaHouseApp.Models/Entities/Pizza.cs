using System.ComponentModel.DataAnnotations;

namespace PizzaHouseApp.Models.Entities
{
    public class Pizza
    {
        public int PizzaId { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; } = "Some Pizza";

        public byte[]? Image { get; set; }

        public double Weight { get; set; }
        public PizzaSize Size { get; set; }

        public bool IsWithMeat { get; set; }
        public decimal Price { get; set; }

        public IEnumerable<Payment> Payments { get; set; } = new List<Payment>();
    }
}
