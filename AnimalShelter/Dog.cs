using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    internal class Dog:Animal
    {

        public bool IsPuppy { get; set; }
        public bool IsChildFriendly { get; set; }

        public Dog() { }

        public Dog(string tempName, string breed, double weight, bool ispuppy, bool ischildfriendly) : base(tempName, breed, weight)
        {
            IsPuppy= ispuppy;
            IsChildFriendly= ischildfriendly;
           
        }




        public void DisplayAllDetails()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Name: " + TempName);
            Console.WriteLine("Breed: " + Breed);
            Console.WriteLine("Weight (kg): " + Weight);
            Console.WriteLine("It is baby? " + IsPuppy);
            Console.WriteLine("It is agressive? " + IsChildFriendly);
            Woff();
            Console.WriteLine("");
        }

        public void Woff()
        {
            
            Console.WriteLine(TempName + " says: WOOOFFFF");
        }

    }
}
