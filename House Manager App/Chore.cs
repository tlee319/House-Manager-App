using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Manager_App
{
    public class Chore
    {
        public string ID { get; set; }
        public string Description { get; set; }
        public int Difficulty { get; set; }
        public bool[] Frequency { get; set; }

        public Chore (string mID, string mDescription, int mDifficulty, bool[] mFrequency)
        {
            ID = mID;
            Description = mDescription;
            Difficulty = mDifficulty;
            Frequency = mFrequency;
        }

        public Chore()
        {
        }
    }
}
