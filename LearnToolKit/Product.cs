using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnToolKit
{
    public partial class Product : ObservableObject
    {
        [ObservableProperty]
        private int id;
        [ObservableProperty]
        private string name = "123";
    }
}
