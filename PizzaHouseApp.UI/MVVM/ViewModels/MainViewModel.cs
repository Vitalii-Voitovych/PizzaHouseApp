using Microsoft.Win32;
using PizzaHouseApp.Dal.EfStructures;
using PizzaHouseApp.Models.Entities;
using PizzaHouseApp.UI.Commands;
using System.IO;
using System.Windows.Media.Imaging;
using System;

namespace PizzaHouseApp.UI.MVVM.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private BaseViewModel? currentView;
        public BaseViewModel? CurrentView
        {
            get => currentView;
            set
            {
                currentView = value;
                OnPropertyChanged();
            }
        }

        public HomeViewModel HomeVM { get; } = new();
        public MenuViewModel MenuVM { get; } = new();
        public CartViewModel CartVM { get; } = new();

        public RelayCommand HomeCommand { get; }
        public RelayCommand MenuCommand { get; }
        public RelayCommand CartCommand { get; }

        public MainViewModel()
        {
            CurrentView = HomeVM;
            HomeCommand = new RelayCommand(() => CurrentView = HomeVM);
            MenuCommand = new RelayCommand(() => CurrentView = MenuVM);
            CartCommand = new RelayCommand(() => CurrentView = CartVM);
        }
    }
}
