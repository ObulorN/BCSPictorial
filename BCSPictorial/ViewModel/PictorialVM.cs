using BCSPictorial.Models;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.Input;
namespace BCSPictorial.ViewModel
{

    public partial class PictorialVM : BaseVM
    {

        [ObservableProperty]
        public ObservableCollection<Pictorial> items;


        public PictorialVM()
        {
            Items = new ObservableCollection<Pictorial>();
        }

        public void LoadItems()
        {



            Items = new ObservableCollection<Pictorial>
            {
               new Pictorial { Image = "sample1.jpg",Description= "I have come by myself, sending no one, i will reveal myself unto the whole world" },
               new Pictorial { Image = "sample2.jpg",Description = "God is love, love is peace, truth, Gospel, blessing, everlasting word of life..." },
               new Pictorial { Image = "sample3.jpg",Description = "There is bound to be wars, famine, and all kinds of problems as long as man continues to sin" },
               new Pictorial { Image = "sample4.jpg",Description = "If you profess to be a child of God, go and perform good deed." },
               new Pictorial { Image = "sample5.jpg",Description = "And again, when he bringeth in the firstbegotten into the world, he saith, And let all the angels of God worship him" },
            new Pictorial { Image = "sample6.jpg",Description = "Olumba puts power in his name" },
             new Pictorial { Image = "sample7.jpg",Description = "The children of God should neither tell lies, nor steal, but they should always be trustworthy" },
            new Pictorial { Image = "sample8.jpg",Description = "The Holy Spirit is the only gift of God. When you possess the Holy Spirit you have everything" },

             new Pictorial { Image = "sample9.jpg",Description = "Olumba puts power in his name" },

              new Pictorial { Image = "sample10.jpg",Description = "Those who will be saved throughout the world are those who will comply with the instructions of God" },
               new Pictorial { Image = "sample11.jpg",Description = "Olumba puts power in his name" },
                
                 new Pictorial { Image = "sample13.jpg",Description = "Olumba puts power in his name" },
                  new Pictorial { Image = "sample14.jpg",Description = "When you are faced with all kinds of trouble when the war becomes topsy-topsy and difficult, tell Him: Father, the time has come, the situation has provided itself for You to come down and arrest. And you will find Him descending upon you like rain from heaven" },
                   new Pictorial { Image = "sample15.jpg",Description = "Olumba puts power in his name" }







            };

        }

    }
}
