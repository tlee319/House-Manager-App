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
        public Chore[] ToDo { get; set; }
        public bool[] TaskGiven { get; set; }

        public Pledge (string mName, bool[] mAvailability)
        {
            Name = mName;
            Availability = mAvailability;
            ToDo = new Chore[7];
            bool[] defaultValues = { false, false, false, false, false, false, false };
            TaskGiven = defaultValues;
        }

        public Pledge()
        {
        }
    }
}
