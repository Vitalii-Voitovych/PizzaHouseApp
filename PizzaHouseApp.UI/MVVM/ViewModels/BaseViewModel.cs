using PizzaHouseApp.Dal.EfStructures;
using PizzaHouseApp.Models;
using PizzaHouseApp.UI.Commands;
using System.Windows;

namespace PizzaHouseApp.UI.MVVM.ViewModels
{
    public class BaseViewModel : ObservableObject
    {
        private static readonly PizzaHouseAppDbContextFactory factory = new();
        public PizzaHouseAppDbContext Context { get; } = factory.CreateDbContext(new string[1]);

        public RelayCommand<Window> CloseCommand { get; }
            = new RelayCommand<Window>(window => window.Close());
        public RelayCommand<Window> MinimizeCommand { get; }
            = new RelayCommand<Window>(window => window.WindowState = WindowState.Minimized);
    }
}
