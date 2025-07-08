using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows;
using static LearnToolKit.MainViewModel;

namespace LearnToolKit
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private string message = "Hello, .NET 8.0 + MVVM Toolkit!";

        [ObservableProperty]
        private Product? selectedProduct;

        [RelayCommand]
        private void ChangeMessage()
        {
            Message = "Message changed!";
        }
        public ObservableCollection<Product> Products { get; } = new()
        {
            new Product { Id = 1, Name = "Apple" },
            new Product { Id = 2, Name = "Banana" }
        };

        [RelayCommand]
        private void MyClick(Product? value)
        {
            if (value is null)
                return;
            if(!value.Name.EndsWith("Click"))
            {
                value.Name += "Click";
            }
            else
            {
                value.Name = value.Name.Substring(0, value.Name.Length - "Click".Length);
            }
        }

    }
}
