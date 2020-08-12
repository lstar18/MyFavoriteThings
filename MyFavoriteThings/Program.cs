using MyFavoriteThings.Favs;
using System;
using System.Security.Cryptography.X509Certificates;

namespace MyFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var mrsun = new Music("Mr.Sun", "kids", "Barney");
            var TenerifeSea = new Music("Tenerife Sea", "Pop", "Ed Sheeran");

            mrsun.Play();
            TenerifeSea.Write();
           

            var pizza = new Food("vegan pizza", true);
            var fries = new Food("french fries", false);
            var tomatoes = new Food("pizza", true);
            var potatoes = new Food("french fries", false);

            tomatoes.Make("tomatoes, dough and cheese");
            pizza.Order();
            potatoes.Make("potaoes and salt");
            fries.Order();

            var watercolor = new Beach("Watercolor", true, "Watercolor, Florida");
            var miami = new Beach("South Beach", false, "South Beach, Florida");

            watercolor.Build();
            miami.Build();

            var old = new Beach("Surf, Jet Ski or Parasail", 15);
            var young = new Beach("Build Sandcastles, Fish, Paddleboat", 9);
            var baby = new Beach("sit in the sand with shovels and buckets", 3);

            old.Do();
            young.Do();
            baby.Do();



        }
    }
}
