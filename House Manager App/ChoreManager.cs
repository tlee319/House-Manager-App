using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Manager_App
{
    public static class ChoreManager
    {
        private static List<ChoreList> ChoreLists = new List<ChoreList>();

        public static void CreateChoreList(DateTime startDate)
        {
            ChoreLists.Add(new ChoreList(AssignPeople(), startDate));
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

        }

        public static void AssignChore()
        {

        }
    }
}
