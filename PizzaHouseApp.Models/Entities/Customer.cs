using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaHouseApp.Models.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required, StringLength(50)]
        public string FirstName { get; set; } = "New";

        [Required, StringLength(50)]
        public string LastName { get; set; } = "Customer";

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string? FullName { get; set; }

        public IEnumerable<Order> Orders { get; set; } = new List<Order>();
    }
}
