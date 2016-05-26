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
        private static string mDataDirectory = Environment.GetEnvironmentVariable("AppData")  + "\\HouseManagerAppData";
        private static string mPledgesDataPath = mDataDirectory + "\\Pledges.XML";
        private static string mBrothersDataPath = mDataDirectory + "\\Brothers.XML";

        public static void InitializeAppSetting()
        {
            AppData.InitializeAppData();

            if (Directory.Exists(mDataDirectory) == false)
            {
                Directory.CreateDirectory(mDataDirectory);
            }

            // Now load that shit
            SetPersonList();
        }

        private static void SetPersonList()
        {
            bool[] availabilityList1 = { false, false, false, true, true, false, false };
            bool[] availabilityList2 = { true, true, false, true, true, false, false };
            bool[] availabilityList3 = { true, true, true, true, true, false, false };

            //Test Data

            List<Pledge> thisList = new List<Pledge>();

            AppData.Pledges.Add(new Pledge("Lloyd1", availabilityList1));
            AppData.Pledges.Add(new Pledge("Lloyd1", availabilityList2));

            AppData.Brothers.Add(new Brother("Bro1", availabilityList2));
            AppData.Brothers.Add(new Brother("Bro2", availabilityList3));

            XmlSerializer xmlSrPledges = new XmlSerializer(typeof(List<Pledge>));
            using (TextWriter writer = new StreamWriter(mPledgesDataPath))
            {
                try
                {
                    xmlSrPledges.Serialize(writer, AppData.Pledges);
                }
                catch
                {
                    //Shit happens
                }
            }

            XmlSerializer xmlSrBrothers = new XmlSerializer(typeof(List<Brother>));
            using (TextWriter writer = new StreamWriter(mBrothersDataPath))
            {
                try
                {
                    xmlSrBrothers.Serialize(writer, AppData.Brothers);
                }
                catch
                {
                    //Shit happens
                }
            }
        }
    }
}
