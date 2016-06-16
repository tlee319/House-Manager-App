using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Manager_App
{
    public class ChoreList
    {
        private bool mIsComplete;
        private List<IPerson> mPersonList;
        private DateTime mStartDay;

        private List<Task> Monday = new List<Task>();
        private List<Task> Tuesday = new List<Task>();
        private List<Task> Wednesday = new List<Task>();
        private List<Task> Thursday = new List<Task>();
        private List<Task> Friday = new List<Task>();
        private List<Task> Saturday = new List<Task>();
        private List<Task> Sunday = new List<Task>();

        #region Get and Set Methods
        public bool IsComplete
        {
            get { return mIsComplete; }
            set { mIsComplete = value; }
        }

        public List<IPerson> PersonList
        {
            get { return mPersonList; }
            set { mPersonList = value; }
        }

        public DateTime StartDay
        {
            get { return mStartDay; }
            set { mStartDay = value; }
        }
        #endregion

        public ChoreList(List<IPerson> mPersonList, DateTime mStartDay)
        {
            IsComplete = false;
            PersonList = mPersonList;
            StartDay = mStartDay;
        }

        public void LoadChoreForEachDay()
        {
            // Populate each Tasks with chores in it that need to be done for each day.
            // We will assign a brother to each Tasks.
            foreach (Chore c in AppData.Chores)
            {
                if (c.Frequency[0] == true)
                {
                    Monday.Add(new Task(c));
                }
                else if (c.Frequency[1] == true)
                {
                    Tuesday.Add(new Task(c));
                }
                else if (c.Frequency[2] == true)
                {
                    Wednesday.Add(new Task(c));
                }
                else if (c.Frequency[3] == true)
                {
                    Thursday.Add(new Task(c));
                }
                else if (c.Frequency[4] == true)
                {
                    Friday.Add(new Task(c));
                }
                else if (c.Frequency[5] == true)
                {
                    Saturday.Add(new Task(c));
                }
                else if (c.Frequency[6] == true)
                {
                    Sunday.Add(new Task(c));
                }
            }
        }
    }
}
