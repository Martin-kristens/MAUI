using ContactApp.ViewModels;
using Shared.Models;
namespace ContactApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }

    }

}
