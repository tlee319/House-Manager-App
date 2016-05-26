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
            //Some kind of bullshit logic for now, but real logic coming up soon
            foreach (Chore c in AppData.Chores)
            {
                // IF monday, add to Monday, or whatever....

                // Think about some logic for this
            }
        }
    }
}
