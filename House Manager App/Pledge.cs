using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Manager_App
{
    public class Pledge : IPerson
    {
        public string Name { get; set; }
        public bool[] Availability { get; set; }

        public Pledge (string mName, bool[] mAvailability)
        {
            Name = mName;
            Availability = mAvailability;
        }

        public Pledge()
        {
        }
    }
}
