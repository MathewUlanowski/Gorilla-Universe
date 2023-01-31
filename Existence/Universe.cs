using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorilla_Universe.Existence
{
    public class Universe
    {
        public Guid ID { get; set; }
        public List<Galaxy> Galaxies { get; set; }
        public Universe()
        {
            ID= Guid.NewGuid();
            BigBang();
        }

        public void BigBang()
        {
            Galaxies= new List<Galaxy>();
            var random = new Random();
            for(var i = 0; i< random.Next(10,1000);i++)
            {
                Galaxies.Add(new Galaxy());
            }
        }
    }
}
