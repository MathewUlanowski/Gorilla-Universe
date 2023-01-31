using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorilla_Universe.Existence
{
    public class StarSystem
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public List<Planet> Planets { get; set; }
        public List<Star> Stars { get; set; }
        public StarSystem() {
            Planets = new List<Planet>();
            Stars = new List<Star>();
            
            var CapSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            this.Name = "";

            for (var i = 0; i < 5; i++)
            {
                var characterIndex = random.Next(0, 36);
                this.Name += CapSet[characterIndex];
            }
            var numberOfPlanets = random.Next(0, 12);
            for (var i = 0; i < numberOfPlanets; i++)
            {
                this.Planets.Add(new Planet());
            }
            var numberOfStars = random.Next(1, 2);
            for (var i = 0; i < numberOfStars; i++)
            {
                var newStar = new Star();
                Stars.Add(newStar);
            }

        }
    }
}
