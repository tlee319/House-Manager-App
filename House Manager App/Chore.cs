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
        //public bool[] frequency?

        public Chore (string mID, string mDescription, int mDifficulty)
        {
            ID = mID;
            Description = mDescription;
            Difficulty = mDifficulty;
        }

        public Chore()
        {
        }
    }
}
