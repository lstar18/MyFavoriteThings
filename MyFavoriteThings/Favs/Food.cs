using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings
{
    class Food
    {   //properties
        public string Name { get; set; }

        private bool _isAvailable = true;

        public string Ingredients { get; set; }

        //constructor
        public Food(string name, bool isAvailable)
        {
            Name = name;
            _isAvailable = isAvailable;
        }
        //method
        public void Order()
        {
            if (_isAvailable)
            {
                Console.WriteLine($"Your {Name} is ready for pick up at the counter.");
            }
            else
            {
                Console.Write($"So we no longer have {Name} available to order.  Please choose another item!");
            }
        }
        public void Make(string Ingredients)
        {

            if(_isAvailable)
            {
                Console.WriteLine($"We have {Ingredients} to make your {Name}! It will be out soon.");
            }
            else
            {
                Console.WriteLine($"We are all out of {Ingredients}!");
            }
        }
    }
}
