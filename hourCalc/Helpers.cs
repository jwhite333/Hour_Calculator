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
            public config(System.DateTime arg0, System.DateTime arg1, System.DateTime arg2, System.DateTime arg3, bool arg4)
            {
                defaultStartOfDayTime = arg0;
                defaultLunchStartTime = arg1;
                defaultLunchEndTime = arg2;
                defaultEndOfDayTime = arg3;
                twoWeekCycleEnabled = arg4;
            }
            public System.DateTime defaultStartOfDay()
            {
                return defaultStartOfDayTime;
            }
            public System.DateTime defaultLunchStart()
            {
                return defaultLunchStartTime;
            }
            public System.DateTime defaultLunchEnd()
            {
                return defaultLunchEndTime;
            }
            public System.DateTime defaultEndOfDay()
            {
                return defaultEndOfDayTime;
            }
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
            var settingsIn = readFile("HC_Settings.dat");
            if (settingsIn.Length <= 0)
            {
                config default_settings = new config(
                    getTime("08:00:00"),
                    getTime("12:00:00"),
                    getTime("13:00:00"),
                    getTime("17:00:00"),
                    true);
                return default_settings;
            }
            else
            {
                config loaded_settings = new config(
                    getTime(settingsIn[0]),
                    getTime(settingsIn[1]),
                    getTime(settingsIn[2]),
                    getTime(settingsIn[3]),
                    Convert.ToBoolean(settingsIn[4]));
                return loaded_settings;
            }
        }

        public double timeToNum(System.DateTime dateTime)
        {
            double hours = (double)dateTime.Hour;
            hours += ((double)dateTime.Minute / 60.0);
            hours += ((double)dateTime.Second / 3600.0);
            return hours;
        }

        public System.DateTime numToTime(double number)
        {
            int hours = (int)(number % 24);
            number -= (double)hours;
            int minutes = (int)((number * 60.0) % 60);
            number -= (double)(minutes / 60.0);
            int seconds = (int)((number * 3600.0) % 3600);

            System.DateTime dateTime = new DateTime(2017, 1, 1, hours, minutes, seconds);
            return dateTime;
        }

        public string timeToString(System.DateTime dateTime)
        {
            string specifier = "  AM";
            int hourNum = dateTime.Hour;
            if (hourNum > 12)
            {
                hourNum = dateTime.Hour - 12;
                specifier = "  PM";
            }
            string hours = hourNum.ToString();
            string minutes = dateTime.Minute.ToString();
            string seconds = dateTime.Second.ToString();
            if (minutes.Length == 1)
                minutes = minutes.Insert(0, "0");
            if (seconds.Length == 1)
                seconds = seconds.Insert(0, "0");
            return (hours + ":" + minutes + ":" + seconds + specifier);
        }

        public System.DateTime getTime(string time)
        {
            // Get formatted time
            while (time[0] == ' ')
                time = time.Substring(1, time.Length - 1);
            int indexOfColon = time.IndexOf(":");
            int hours = System.Convert.ToInt32(time.Substring(0, indexOfColon));
            int minutes = System.Convert.ToInt32(time.Substring(indexOfColon + 1, 2));
            int seconds = System.Convert.ToInt32(time.Substring(indexOfColon + 4, 2));

            // Create a DateTime object
            System.DateTime dateTime = new DateTime(2017, 1, 1, hours, minutes, seconds);
            return dateTime;
        }

        public string formatTime(System.DateTime dateTime)
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
            return(hours + ":" + minutes + ":" + seconds);
        }
    }
}
