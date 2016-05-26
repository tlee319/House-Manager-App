using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Manager_App
{
    public class Brother : IPerson
    {
        public string Name { get; set; }
        public bool[] Availability { get; set; }
        public Chore[] ToDo { get; set; }

        public Brother(string mName, bool[] mAvailability)
        {
            Name = mName;
            Availability = mAvailability;
            ToDo = new Chore[7];
        }

        public Brother()
        {
        }
    }
}
