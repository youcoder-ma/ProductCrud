using ProductMg.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProductMg.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeView : ContentPage
    {
        public HomeView(HomeViewModel homeViewModel)
        {
            InitializeComponent();

            homeViewModel.Navigation = Navigation;
            BindingContext = homeViewModel;
        }
    }
}