using PizzaHouseApp.Models;
using PizzaHouseApp.UI.Commands;

namespace PizzaHouseApp.UI.MVVM.ViewModels
{
    public partial class CartViewModel : BaseViewModel
    {
        public RelayCommand CartClearCommand { get; }
        public RelayCommand<CartItem> UpCountCommand { get; }
        public RelayCommand<CartItem> DownCountCommand { get; }
        public RelayCommand<CartItem> RemoveCommand { get; }

        public CartViewModel()
        {
            CartClearCommand = new RelayCommand(() =>
            {
                Cart.Clear();
            });
            UpCountCommand = new RelayCommand<CartItem>(cartItem =>
            {
                cartItem.Count++;
            });
            DownCountCommand = new RelayCommand<CartItem>(cartItem =>
            {
                cartItem.Count--;
            });
            RemoveCommand = new RelayCommand<CartItem>(cartItem =>
            {
                Cart.Remove(cartItem);
            });
        }
    }
}
