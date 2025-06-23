using BCSPictorial.Models;
using System.Collections.ObjectModel;

namespace BCSPictorial
{
    public partial class MainPage : ContentPage
    {
   ObservableCollection<Pictorial> items = new ObservableCollection<Pictorial>();

        public MainPage()
        {
            InitializeComponent();
            
        }

      
    }

}
