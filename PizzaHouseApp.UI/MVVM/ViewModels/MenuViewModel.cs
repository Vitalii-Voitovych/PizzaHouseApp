using PizzaHouseApp.Models.Entities;
using PizzaHouseApp.UI.Commands;
using System.Collections.Generic;
using System.Linq;

namespace PizzaHouseApp.UI.MVVM.ViewModels
{
    public partial class MenuViewModel : BaseViewModel
    {
        public List<Pizza>? Pizzas { get; }
        
        //TODO: Вирішити проблему із кількустю
        private int _number = 0;
        public int Number
        {
            get => _number;
            set
            {
                _number = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand UpNumberCommand { get; }
        public RelayCommand DownNumberCommand { get; }
        public RelayCommand<Pizza> AddToCartCommand { get; }

        public MenuViewModel()
        {
            Pizzas = Context.Pizzas?.ToList();

            UpNumberCommand = new RelayCommand(() =>
            {
                if (Number < 10)
                {
                    Number++;
                }
            });
            DownNumberCommand = new RelayCommand(() =>
            {
                if (Number > 0)
                {
                    Number--;
                }
            });
            AddToCartCommand = new RelayCommand<Pizza>((pizza) =>
            {
                Cart.Add(pizza, Number);
            });
        }
    }
}
