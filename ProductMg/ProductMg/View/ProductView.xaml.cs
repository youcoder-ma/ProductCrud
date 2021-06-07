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
    public partial class ProductView : ContentPage
    {
        public ProductView(ProductViewModel productViewModel)
        {
            InitializeComponent();
            productViewModel.Navigation = Navigation;
            BindingContext = productViewModel;
        }
    }
}