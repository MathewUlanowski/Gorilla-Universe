using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorilla_Universe.Existence
{
    public class Planet
    {
        public Guid ID { get; set; }
        public bool HasAtmosphere { get; set; }

        public List<Continent> Continents { get; set; }
        public Planet()
        {
            this.ID = Guid.NewGuid();
            this.Continents = new List<Continent>();
            Random random = new Random();
            int instanceOfChanceToHaveAtmosphere = random.Next(0, 1001);
            if(instanceOfChanceToHaveAtmosphere > 998)
            {
                this.HasAtmosphere= true;
            }
            else
            {
                this.HasAtmosphere= false;
            }

            int numberOfContinents = random.Next(1, 21);
            for(var i = 1; i <= numberOfContinents; i++) {
                this.Continents.Add(new Continent(this.ID, i, HasAtmosphere));
            }
        }
    }
}
