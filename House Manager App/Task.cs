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
    }
}
