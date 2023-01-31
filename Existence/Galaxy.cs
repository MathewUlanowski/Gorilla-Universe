using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorilla_Universe.Existence
{
    public class Galaxy
    {
        public Guid ID { get; set; }
        public List<StarSystem> StarSystems { get; set; }

        public Galaxy()
        {
            ID = Guid.NewGuid();
            StarSystems = new List<StarSystem>();

            var random = new Random();
            var numberOfStarSystems = random.Next(500, 10000);
            for(var i = 0; i < numberOfStarSystems; i++)
            {
                StarSystems.Add(new StarSystem());
            }
        }
    }
}
