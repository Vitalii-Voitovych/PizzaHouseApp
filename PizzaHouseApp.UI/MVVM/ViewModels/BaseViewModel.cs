using PizzaHouseApp.Models.Entities;
using PizzaHouseApp.UI.Commands;
using System.Windows;

namespace PizzaHouseApp.UI.MVVM.ViewModels
{
    public class BaseViewModel : ObservableObject
    {
        public RelayCommand<Window> CloseCommand { get; }
            = new RelayCommand<Window>(window => window.Close());
        public RelayCommand<Window> MinimizeCommand { get; }
            = new RelayCommand<Window>(window => window.WindowState = WindowState.Minimized);
    }
}
