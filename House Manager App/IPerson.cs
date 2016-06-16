using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Manager_App
{
    public interface IPerson
    {
        bool[] Availability { get; set; }
        Chore[] ToDo { get; set; }
        bool[] TaskGiven { get; set; }
    }
}
