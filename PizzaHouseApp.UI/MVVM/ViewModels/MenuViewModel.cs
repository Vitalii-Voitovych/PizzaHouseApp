using PizzaHouseApp.Models.Entities;
using System.Collections.Generic;
using System.Linq;

namespace PizzaHouseApp.UI.MVVM.ViewModels
{
    public partial class MenuViewModel : BaseViewModel
    {
        public List<Pizza>? Pizzas { get; }

        public MenuViewModel()
        {
            Pizzas = Context.Pizzas?.ToList();
        }
    }
}
