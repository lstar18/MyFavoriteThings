using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Favs
{
    class Music
    //property
    {
        public string Name { get; set; }

        public string TypeOfMusic { get; set; }
        public string Artist { get; set; }


        //constructor
        public Music(string name, string type, string artist)
        {
            Name = name;
            TypeOfMusic = type;
            Artist = artist;
        }
        //method
        public void Play()
        {
            Console.WriteLine($"{Name} is the best {TypeOfMusic} song and is written by {Artist}.");
        }

        //method
        public void Write()
        {
            Console.WriteLine($"{Artist} wrote the song I danced my first dance to at my wedding, {Name}.");
        }
    }
}
