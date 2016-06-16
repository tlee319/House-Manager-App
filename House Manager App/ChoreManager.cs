using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Manager_App
{
    public static class ChoreManager
    {
        // Will be using a dictionary in the future
        private static ChoreList mChoreList1;

        public static void CreateChoreList(DateTime startDate)
        {
            mChoreList1 = new ChoreList(AssignPeople(), startDate);
        }

        public static List<IPerson> AssignPeople()
        {
            // For now we are bullshitting, but later we will add some
            // logic that makes sense

            List<IPerson> returnList = new List<IPerson>();

            foreach (IPerson person in AppData.Brothers)
            {
                returnList.Add(person);
            }

            foreach (IPerson person in AppData.Pledges)
            {
                returnList.Add(person);
            }

            return returnList;
        }

        public static void AssignChores()
        {
            mChoreList1.LoadChoreForEachDay();
            mChoreList1.LoadPeopleForEachDay();
            mChoreList1.AssignChoresToPeople();
        }
    }
}
