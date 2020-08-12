using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings
{
    class Beach
    {
        public string Name { get; private set; }
        public bool _isSunny { get; private set; }
        public string Location { get; private set; }
        public int Age { get; set; }

        public string Activity { get; set; }
        public Beach(string name, bool isSunny, string location)
        {
            Name = name;
            _isSunny = isSunny;
            Location = location;

        }
        public void Build()
        {

            if(_isSunny)
            {
                Console.WriteLine($"The weather is great in {Name}! We should build a sandcastle!");
            }
            else
            {
                Console.WriteLine($"The weather is bad in {Location} so we should play inside for now!");
            }
        }
        public Beach(string activity, int age)
        {
            Activity = activity;
            Age = age;
        }
        public void Do()
        {
            if(Age >= 10)
            {
                Console.WriteLine($"You are older than {Age} so you can {Activity} today!");
            }
           else if (Age >= 5)
            {
                Console.WriteLine($"You are at least {Age} so you can {Activity} today!");
            }
            else if (Age < 5)
            {
                Console.WriteLine($"One day you will be old enough to do something beside {Activity}!");
            }
        }
    }
}
