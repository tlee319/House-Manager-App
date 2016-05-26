using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Manager_App
{
    class Chore
    {
        private string ID { get; set; }
        private string Description { get; set; }
        private int Difficulty { get; set; }

        public Chore (string mID, string mDescription, int mDifficulty)
        {
            ID = mID;
            Description = mDescription;
            Difficulty = mDifficulty;
        }
    }
}
