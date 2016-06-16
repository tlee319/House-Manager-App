using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Manager_App
{
    public class Task
    {
        private IPerson mAssignedPerson;
        private Chore mAssignedChore;

        public Task (Chore assignedChore)
        {
            mAssignedChore = assignedChore;
        }

        public bool AssignPerson(IPerson person, int day)
        {
            // The null exception here probably has to do with the fact that the XML data files weren't updated.
            // god dammit. Test this later. TaskGiven is probably not necessary.... maybe it will be.
            if (person.TaskGiven[day] == false)
            {
                person.TaskGiven[day] = true;
                person.ToDo[day] = mAssignedChore;
                mAssignedPerson = person;
                return true;
            }
            return false;
        }
    }
}
