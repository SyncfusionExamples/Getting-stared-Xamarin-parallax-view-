using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;

using Xamarin.Forms;

namespace ParallaxView_Sample
{
    public class ParallaxViewModel
    {
        public ImageSource Image { get; set; }
        public ObservableCollection<Contacts> Items { get; set; }
        public ParallaxViewModel()
        {
            Assembly assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Image = ImageSource.FromResource("ParallaxView_Sample.Images.ParallaxWallpaper.png", assembly);
            Items = new ObservableCollection<Contacts>()
            { new Contacts() { Name = "Thriller", Author = "Michael Jackson - 10 Tracks",Tracks="10 Tracks" },
                new Contacts() { Name = "Like a Prayer", Author = "Madonna - 1 Tracks" ,Tracks="1 Tracks" },
                new Contacts() { Name = "When Doves Cry", Author = "Prince - 60 Tracks",Tracks="60 Tracks" },
                new Contacts() { Name = "I Wanna Dance", Author = "Whitney Houston - 70 Tracks",Tracks="70 Tracks" },
                new Contacts() { Name = "It’s Gonna Be Me", Author = "N Sync - 10 Tracks",Tracks="10 Tracks" },
                new Contacts() { Name = "Everybody", Author = "Backstreet Boys - 4 Tracks",Tracks="4 Tracks" },
                new Contacts() { Name = "Rolling in the Deep", Author = "Adele - 25 Tracks" ,Tracks="25 Tracks" },
                new Contacts() { Name = "Don’t Stop Believing", Author = "Journey - 10 Tracks" ,Tracks="10 Tracks" },
                new Contacts() { Name = "Billie Jean", Author = "Michael Jackson - 5 Tracks",Tracks="5 Tracks" },
                new Contacts() { Name = "Sorry", Author = "Justin Bieber - 1 Tracks",Tracks="1 Tracks" },
                new Contacts() { Name = "Firework", Author = "Katy Perry - 6 Tracks",Tracks="6 Tracks" },
                new Contacts() { Name = "The A Team", Author = "Ed Sheeran - 8 Tracks" ,Tracks="8 Tracks"},
                new Contacts() { Name = "Thriller", Author = "Michael Jackson - 3 Tracks" ,Tracks="3 Tracks"},
                new Contacts() { Name = "Like a Prayer", Author = "Madonna - 40 Tracks" ,Tracks="40 Tracks"},
                new Contacts() { Name = "When Doves Cry", Author = "Prince - 10 Tracks",Tracks="10 Tracks" },
                new Contacts() { Name = "I Wanna Dance", Author = "Whitney Houston - 2 Tracks",Tracks="2 Tracks" },
                new Contacts() { Name = "It’s Gonna Be Me", Author = "N Sync - 11 Tracks" ,Tracks="11 Tracks"},
                new Contacts() { Name = "Everybody", Author = "Backstreet Boys - 15 Tracks",Tracks="15 Tracks" },
                new Contacts() { Name = "Rolling in the Deep", Author = "Adele - 18 Tracks" ,Tracks="18 Tracks"},
                new Contacts() { Name = "Don’t Stop Believing", Author = "Journey - 35 Tracks",Tracks="35 Tracks" },
            };
            for (int i = 0; i < Items.Count; i++)
            {
                Items[i].LImage = ImageSource.FromResource("ParallaxView_Sample.Images.ParallaxGuitar" + (i + 1) % 12 + ".png", assembly);
            }
        }
    }
}