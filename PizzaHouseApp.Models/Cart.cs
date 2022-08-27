using PizzaHouseApp.Models.Entities;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace PizzaHouseApp.Models
{
    public class Cart : ObservableObject, IEnumerable
    {
        public ObservableCollection<CartItem> Pizzas { get; }

        private decimal _price;
        public decimal Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged();
            }
        }
        public Cart()
        {
            Pizzas = new ObservableCollection<CartItem>();
            Pizzas.CollectionChanged += Pizzas_CollectionChanged;
        }

        private void Pizzas_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
                foreach (var item in e.NewItems.Cast<CartItem>())
                    item.PropertyChanged += OnChanged;

            if (e.OldItems != null)
                foreach (var item in e.OldItems.Cast<CartItem>())
                    item.PropertyChanged -= OnChanged;
        }

        private void OnChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (sender is CartItem c && c.Count <= 0)
            {
                Pizzas.Remove(c);
            }
            UpdatePrice();
        }

        public void Clear() => Pizzas.Clear();
        public void UpdatePrice() => Price = GetAll().Sum(p => p.Price);

        public void Add(Pizza pizza, int count)
        {
            var cartItem = Pizzas.FirstOrDefault(c => c.Pizza.Name == pizza.Name);
            if (cartItem != null)
            {
                cartItem.Count += count;
            }
            else
            {
                Pizzas.Add(new CartItem(pizza, count));
            }
        }

        private List<Pizza> GetAll()
        {
            var pizzas = new List<Pizza>();
            foreach (Pizza pizza in this)
            {
                pizzas.Add(pizza);
            }
            return pizzas;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in Pizzas)
            {
                for (int i = 0; i < item.Count; i++)
                {
                    yield return item.Pizza;
                }
            }
        }
    }
}
