using BCSPictorial.Models;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.Input;
namespace BCSPictorial.ViewModel
{
   
    public partial  class PictorialVM:BaseVM
    {
      
        [ObservableProperty]
        public ObservableCollection<Pictorial> items;
       

        public PictorialVM()
        {
            Items = new ObservableCollection<Pictorial>();
        }

        public  void LoadItems()
        {
         
            

            Items = new ObservableCollection<Pictorial>
            {
               new Pictorial { Image = "sample1.jpg",Description= "I have come by myself, sending no one, i will reveal myself unto the whole world" },
               new Pictorial { Image = "sample2.jpg",Description = "God is love, love is peace, truth, Gospel, blessing, everlasting word of life..." },
               new Pictorial { Image = "sample3.jpg",Description = "When you offer seriuos prayer without love, it cannot meet the target" },
               new Pictorial { Image = "sample4.jpg",Description = "If you profess to be a child of God, go and perform good deed." },
               new Pictorial { Image = "sample5.jpg",Description = "Olumba puts power in his name" }
            };

        }

    }
}
