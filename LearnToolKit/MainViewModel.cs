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
        public partial class Product : ObservableObject
        {
            [ObservableProperty]
            private int id;
            [ObservableProperty]
            private string name = "123";
        }
        public ObservableCollection<Product> Products { get; } = new()
        {
            new Product { Id = 1, Name = "Apple" },
            new Product { Id = 2, Name = "Banana" }
        };

        partial void OnSelectedProductChanged(Product? value)
        {
            if (value is null)
                return;
            if (!value.Name.EndsWith("Click"))
            {
                value.Name += "Click";
            }
        }

    }
}
