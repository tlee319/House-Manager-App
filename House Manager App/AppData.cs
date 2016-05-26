using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_Manager_App
{
    public static class AppData
    {
        public static List<Pledge> Pledges { get; set; }
        public static List<Brother> Brothers { get; set; }

        public static void InitializeAppData()
        {
            Pledges = new List<Pledge>();
            Brothers = new List<Brother>();
        }
    }
}
