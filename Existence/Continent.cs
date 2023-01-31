using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorilla_Universe.Existence
{
    public class Continent
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Animal> Animals = new List<Animal>();
        public string Climate { get; set; }

        public Continent(Guid planetID, int contitnetNumber, bool hasAtmosphere) {
            this.Id = Guid.NewGuid();
            this.Name = $"{planetID}-{contitnetNumber}";
            if(hasAtmosphere)
            {
                Random random = new Random();
                var lifeDensity = random.Next(0,100);
                for (var i = 0; i < lifeDensity; i++)
                {
                    int randomNumber = random.Next(1, 101);
                    if (randomNumber > 60)
                    {
                        Animals.Add(new Animal("Banana"));
                    }
                    else
                    {
                        Animals.Add(new Animal("Gorilla"));
                    }
                }
            }

        }
    }
}
