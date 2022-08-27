using PizzaHouseApp.Models.Entities;

namespace PizzaHouseApp.Models
{
    public class CartItem : ObservableObject
    {
        public Pizza Pizza { get; set; }

        private int _count;
        public int Count
        {
            get => _count;
            set
            {
                _count = value;
                OnPropertyChanged();
            }
        }

        public CartItem(Pizza pizza, int count)
        {
            Pizza = pizza;
            Count = count;
        }
    }
}
