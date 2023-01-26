using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    internal class Animal
    {
        private static int ids;
        public int Id { get; set; }
        public string TempName { get; set; }
        public string Breed { get; set; }
        public double Weight { get; set; }

        public Animal() {
            this.Id = System.Threading.Interlocked.Increment(ref ids);
        }
        public Animal(string tempName, string breed, double weight)
        {
            this.Id=System.Threading.Interlocked.Increment(ref ids);
            TempName = tempName;
            Breed = breed;
            Weight = weight;
        }





        
    }
}
