using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AnimalShelter
{
    internal class Cat:Animal
    {
        public bool IsKitten { get; set; }
        public bool IsAgressive { get; set; }

        public Cat() { }

        public Cat(string tempName, string breed, double weight, bool iskitten, bool isagressive) : base(tempName, breed, weight) { 
            IsKitten = iskitten;
            IsAgressive = isagressive;
            
        }




        public void DisplayAllDetails()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("ID: "+Id);
            Console.WriteLine("Name: "+TempName);
            Console.WriteLine("Breed: "+Breed);
            Console.WriteLine("Weight (kg): "+Weight);
            Console.WriteLine("It is baby? "+IsKitten);
            Console.WriteLine("It is agressive? "+IsAgressive);
            Meow();
            Console.WriteLine("");
        }

        public void Meow()
        {
            
            Console.WriteLine(TempName+" says: MEOOOOWWW");
        }
        
    }
}
