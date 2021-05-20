using PubWPF_MVVM.Command;
using PubWPF_MVVM.Models;
using PubWPF_MVVM.Repo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;


namespace PubWPF_MVVM.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public Repository DrinkRepo { get; set; }
        public ObservableCollection<Drink> Drinks { get; set; }

        private Drink _drink;
        public Drink Drink
        {
            get { return _drink; }
            set { _drink = value; OnPropertyChanged(); }
        }

        private int _count;

        public int Count
        {
            get { return _count; }
            set { _count = value; OnPropertyChanged(); }
        }

        private ObservableCollection<Drink> _soldDrinks;

        public ObservableCollection<Drink> SoldDrinks
        {
            get { return _soldDrinks; }
            set { _soldDrinks = value; }
        }



        public RelayCommand SelectionChangedCommand { get; set; }
        public RelayCommand IncreaseCommand { get; set; }
        public RelayCommand DecreaseCommand { get; set; }
        public RelayCommand BuyCommand { get; set; }

        public MainViewModel()
        {
            DrinkRepo = new Repository();
            Drinks = new ObservableCollection<Drink>(DrinkRepo.GetDrinks());

            IncreaseCommand = new RelayCommand(
                (e) =>
                {
                    Count++;
                });

            DecreaseCommand = new RelayCommand(
                (e) =>
                {
                    Count--;
                },
                (c) =>
                {
                    if (Count > 0) return true;
                    return false;
                });

            BuyCommand = new RelayCommand(
                (e) =>
                {
                    try
                    {
                        SoldDrinks.Add(Drink);
                        MessageBox.Show($"Total price is ${Count * Drink.Price}");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Drink not selected");
                    }
                });
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
