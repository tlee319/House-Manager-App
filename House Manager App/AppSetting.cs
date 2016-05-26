using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace House_Manager_App
{
    public static class AppSetting
    {
        private static string sDataDirectory = Environment.GetEnvironmentVariable("AppData")  + "\\HouseManagerAppData";
        private static string sPledgesDataPath = sDataDirectory + "\\Pledges.XML";
        private static string sBrothersDataPath = sDataDirectory + "\\Brothers.XML";
        private static string sChoresDataPath = sDataDirectory + "\\Chores.XML";

        public static void InitializeAppSetting()
        {
            AppData.InitializeAppData();

            if (Directory.Exists(sDataDirectory) == false)
            {
                Directory.CreateDirectory(sDataDirectory);
            }

            // Load that shit
            LoadPersonList();
            LoadChores();

            // These data are only temporary, but will be modified later and used in the code
            //SetPersonList();
            //SetChores();
        }

        private static void LoadChores()
        {
            if (File.Exists(sChoresDataPath))
            {
                XmlSerializer xmlSrChore = new XmlSerializer(typeof(List<Chore>));
                using (FileStream reader = new FileStream(sChoresDataPath, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    try
                    {
                        AppData.Chores = (List<Chore>)xmlSrChore.Deserialize(reader);
                    }
                    catch
                    {
                        //Shit happens, create logs later
                    }
                }
            }
        }

        private static void LoadPersonList()
        {
            if (File.Exists(sBrothersDataPath))
            {
                XmlSerializer xmlSrBrother = new XmlSerializer(typeof(List<Brother>));
                using (FileStream reader = new FileStream(sBrothersDataPath, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    try
                    {
                        AppData.Brothers = (List<Brother>)xmlSrBrother.Deserialize(reader);
                    }
                    catch
                    {
                        //Shit happens, create logs later
                    }
                }
            }

            if (File.Exists(sPledgesDataPath))
            {
                XmlSerializer xmlSrPledge = new XmlSerializer(typeof(List<Pledge>));
                using (FileStream reader = new FileStream(sPledgesDataPath, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    try
                    {
                        AppData.Pledges = (List<Pledge>)xmlSrPledge.Deserialize(reader);
                    }
                    catch
                    {
                        //Shit happens, create logs later
                    }
                }
            }
        }

        private static void SetChores()
        {
            AppData.Chores.Add(new Chore("1", "Clean Bathroom", 6));
            AppData.Chores.Add(new Chore("2", "Do Dishes", 10));
            AppData.Chores.Add(new Chore("3", "Take out the trash", 3));
            AppData.Chores.Add(new Chore("4", "Clean the water fountain", 1));

            XmlSerializer xmlSrChores = new XmlSerializer(typeof(List<Chore>));
            using (TextWriter writer = new StreamWriter(sChoresDataPath))
            {
                try
                {
                    xmlSrChores.Serialize(writer, AppData.Chores);
                }
                catch
                {
                    //Shit happens
                }
            }
        }

        private static void SetPersonList()
        {
            bool[] availabilityList1 = { false, false, false, true, true, false, false };
            bool[] availabilityList2 = { true, true, false, true, true, false, false };
            bool[] availabilityList3 = { true, true, true, true, true, false, false };

            //Test Data

            AppData.Pledges.Add(new Pledge("Lloyd1", availabilityList1));
            AppData.Pledges.Add(new Pledge("Lloyd1", availabilityList2));

            AppData.Brothers.Add(new Brother("Bro1", availabilityList2));
            AppData.Brothers.Add(new Brother("Bro2", availabilityList3));

            XmlSerializer xmlSrPledges = new XmlSerializer(typeof(List<Pledge>));
            using (TextWriter writer = new StreamWriter(sPledgesDataPath))
            {
                try
                {
                    xmlSrPledges.Serialize(writer, AppData.Pledges);
                }
                catch
                {
                    //Shit happens, log it out later
                }
            }

            XmlSerializer xmlSrBrothers = new XmlSerializer(typeof(List<Brother>));
            using (TextWriter writer = new StreamWriter(sBrothersDataPath))
            {
                try
                {
                    xmlSrBrothers.Serialize(writer, AppData.Brothers);
                }
                catch
                {
                    //Shit happens, log it out later
                }
            }
        }
    }
}
