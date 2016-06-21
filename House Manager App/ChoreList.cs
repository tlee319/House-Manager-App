using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Manager_App
{
    public class ChoreList
    {
        private static Random Rand;
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

        private List<List<Task>> TaskList = new List<List<Task>>();

        private List<IPerson> MondayPeople = new List<IPerson>();
        private List<IPerson> TuesdayPeople = new List<IPerson>();
        private List<IPerson> WednesdayPeople = new List<IPerson>();
        private List<IPerson> ThursdayPeople = new List<IPerson>();
        private List<IPerson> FridayPeople = new List<IPerson>();
        private List<IPerson> SaturdayPeople = new List<IPerson>();
        private List<IPerson> SundayPeople = new List<IPerson>();

        private List<List<IPerson>> PeopleList = new List<List<IPerson>>();

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
            Rand = new Random();
        }


        public void AssignChoresToPeople()
        {
            // All this should be turned into classes with names and shits
            int dayCounter = 0;
            foreach (List<Task> dayTasks in TaskList)
            {
                int count = 0;
                foreach (Task t in dayTasks)
                {
                    bool isAdded = false;
                    while (isAdded == false)
                    {
                        int randomInteger = Rand.Next(dayTasks.Count);
                        isAdded = t.AssignPerson(PeopleList[dayCounter][randomInteger], dayCounter);
                    }
                    count++;
                    if (dayTasks.Count == count)
                    {
                        break;
                    }
                }
                dayCounter++;
            }



            int counter = 0;
            // As long as we have more people than tasks, we good fam
            if (Monday.Count <= MondayPeople.Count)
            {
                foreach (Task t in Monday)
                {
                    bool isAdded = false;
                    while (isAdded == false)
                    {
                        int randomInteger = Rand.Next(MondayPeople.Count);
                        isAdded = t.AssignPerson(MondayPeople[randomInteger], 0);
                    }
                    counter++;
                    if (Monday.Count == counter)
                    {
                        break;
                    }
                }
            }

            if (Tuesday.Count <= TuesdayPeople.Count)
            {
                foreach (Task t in Tuesday)
                {
                    bool isAdded = false;
                    while (isAdded == false)
                    {
                        int randomInteger = Rand.Next(MondayPeople.Count);
                        isAdded = t.AssignPerson(MondayPeople[randomInteger],1);
                    }
                    counter++;
                    if (TuesdayPeople.Count == counter)
                    {
                        break;
                    }
                }
            }
        }

        public void LoadPeopleForEachDay()
        {
            foreach (IPerson p in mPersonList)
            {
                if (p.Availability[0] == true)
                {
                    MondayPeople.Add(p);
                }
                if (p.Availability[1] == true)
                {
                    TuesdayPeople.Add(p);
                }
                if (p.Availability[2] == true)
                {
                    WednesdayPeople.Add(p);
                }
                if (p.Availability[3] == true)
                {
                    ThursdayPeople.Add(p);
                }
                if (p.Availability[4] == true)
                {
                    FridayPeople.Add(p);
                }
                if (p.Availability[5] == true)
                {
                    SaturdayPeople.Add(p);
                }
                if (p.Availability[6] == true)
                {
                    SundayPeople.Add(p);
                }
            }

            PeopleList.Add(MondayPeople);
            PeopleList.Add(TuesdayPeople);
            PeopleList.Add(WednesdayPeople);
            PeopleList.Add(ThursdayPeople);
            PeopleList.Add(FridayPeople);
            PeopleList.Add(SaturdayPeople);
            PeopleList.Add(SundayPeople);
        }

        public void LoadChoreForEachDay()
        {
            // Populate each Tasks with chores in it that need to be done for each day.
            // We will assign a brother to each Tasks.
            // We actually don't wanna use AppDAta.Chores. Later we might want to have different
            // sets of chores for different occation. For example, daily chores will be different 
            // from work week.
            foreach (Chore c in AppData.Chores)
            {
                if (c.Frequency[0] == true)
                {
                    Monday.Add(new Task(c));
                }
                if (c.Frequency[1] == true)
                {
                    Tuesday.Add(new Task(c));
                }
                if (c.Frequency[2] == true)
                {
                    Wednesday.Add(new Task(c));
                }
                if (c.Frequency[3] == true)
                {
                    Thursday.Add(new Task(c));
                }
                if (c.Frequency[4] == true)
                {
                    Friday.Add(new Task(c));
                }
                if (c.Frequency[5] == true)
                {
                    Saturday.Add(new Task(c));
                }
                if (c.Frequency[6] == true)
                {
                    Sunday.Add(new Task(c));
                }
            }

            TaskList.Add(Monday);
            TaskList.Add(Tuesday);
            TaskList.Add(Wednesday);
            TaskList.Add(Thursday);
            TaskList.Add(Friday);
            TaskList.Add(Saturday);
            TaskList.Add(Sunday);
        }
    }
}
