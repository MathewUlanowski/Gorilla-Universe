using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorilla_Universe.Existence
{
    public class Animal
    {
        public bool IsInACult;
        public string Species;
        public Guid animalID;
        public Animal(string species) {
            this.Species = species;
            this.animalID= Guid.NewGuid();

            if (species == "Gorilla")
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 11);
                if(randomNumber>9)
                {
                    IsInACult= true;
                }
                else
                {
                    IsInACult= false;
                }
            }
            else
            {
                IsInACult= false;
            }
        }
    }
}
