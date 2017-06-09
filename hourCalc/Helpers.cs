using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hourCalc
{
    // Do generic things like load files
    class Helpers
    {
        // Settings object
        public struct config
        {
            // Add default constructor and data modifiers
            System.DateTime defaultStartOfDayTime;
            System.DateTime defaultLunchStartTime;
            System.DateTime defaultLunchEndTime;
            System.DateTime defaultEndOfDayTime;
            bool twoWeekCycleEnabled;
        };

        // Create formatted string from dateTime for file output
        public string dateTimeOutput(System.DateTime dateTime)
        {
            string hours = dateTime.Hour.ToString();
            if (hours.Length == 1)
                hours = hours.Insert(0, "0");
            string minutes = dateTime.Minute.ToString();
            if (minutes.Length == 1)
                minutes = minutes.Insert(0, "0");
            string seconds = dateTime.Second.ToString();
            if (seconds.Length == 1)
                seconds = seconds.Insert(0, "0");
            return (hours + ":" + minutes + ":" + seconds);
        }

        // Read values from a file into string array
        public string [] readFile(string file)
        {
            System.Collections.Generic.List<string> lineList = new System.Collections.Generic.List<string>();
            System.IO.FileStream fileStream = new System.IO.FileStream(file, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Read);
            using (var streamReader = new System.IO.StreamReader(fileStream))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    lineList.Add(line);
                }
            }
            fileStream.Close();
            return lineList.ToArray();
        }

        // Retreive settings
        public config getSettings()
        {
            config settings = new config();

            var settingsIn = readFile("HC_Settings.dat");
            if (settingsIn.Length <= 0)
            {
                return settings;
            }
            else
            {
                //settings.
            }

            return settings;
        }
    }
}
