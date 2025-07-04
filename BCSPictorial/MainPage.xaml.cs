using BCSPictorial.Models;
using BCSPictorial.ViewModel;
using BCSPictorial.Helpers;
using System.Collections.ObjectModel;

namespace BCSPictorial
{
    public partial class MainPage : ContentPage
    {
       PictorialVM _vm;

        public MainPage(PictorialVM vm)
        {
            InitializeComponent();
                
           BindingContext = _vm=vm ;
        }
        override protected async void OnAppearing()
        {
            base.OnAppearing();
          _vm.LoadItems();
        }
       
    }

}
