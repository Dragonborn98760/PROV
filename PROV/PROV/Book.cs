using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROV
{
    class Book
    {
        //different variables
        public int price;

        private string title;

        private int rarity;

        private string category;

        private int actiualValue;

        private bool cursed;
        //generator
        private Random Generator = new Random();
        //lists for names and categories
        List<string> books = new List<string>() { "A", "B", "C" };

        List<string> categories = new List<string>() { "Fantasy", "Si-Fi", "History" };


        //method for creation a book
        public void BookInfo()
        {
            //basically get random numbers for each variable before 
            rarity = Generator.Next(1, 100);

            actiualValue = Generator.Next(50, 100);

            title = books[Generator.Next(0, 2)];

            category = categories[Generator.Next(0, 2)];
            //deciding if book is cursed
            cursed = false;
            if (cursed == false)
            {
                int curse;
                //if it is then make the bool true
                curse = Generator.Next(0, 1);

                if (curse == 1)
                {
                    cursed = true;
                }
            }


        }
        //prints info about the book
        public void PrintInfo()
        {
            
            Console.WriteLine("title: " + title);

            Console.WriteLine("rarity: " + rarity);

            Console.WriteLine("category: " + category);

            Console.WriteLine("price: " + price);
        }
        //evaluates the price of the book and then sets a price on it
        public void Evaluate(int price)
        {
            this.price = price;
            int rightPrice;
            int priceMultiplicator;

            rightPrice = actiualValue * rarity;

            priceMultiplicator = Generator.Next(50, 150);

            price = rightPrice * (priceMultiplicator/100);
        }
        //returnes category of the book
        public void GetCategory()
        {
            Console.WriteLine("category: " + category);
        }
        //returnes name of the book
        public void GetName()
        {
            Console.WriteLine("title: " + title);
        }

        //checks if the book is really cursed
        public void IsCursed()
        {

            //this check can fail
            int fakeCurse = Generator.Next(1, 100);

            //if it fails change the bool to the opposite of what it was
            if (fakeCurse > 80)
            {
                if (cursed == true)
                {
                    cursed = false;
                }
                else
                {
                    cursed = true;
                }
            }
        }
    }
    
}
