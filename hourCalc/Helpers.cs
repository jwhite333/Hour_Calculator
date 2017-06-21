using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hourCalc
{
    // Day structure
    public struct day
    {
        public day(System.Windows.Forms.DateTimePicker arg0, System.Windows.Forms.DateTimePicker arg1, System.Windows.Forms.DateTimePicker arg2, System.Windows.Forms.DateTimePicker arg3)
        {
            start = arg0;
            lunchStart = arg1;
            lunchEnd = arg2;
            end = arg3;
        }
        public System.Windows.Forms.DateTimePicker start;
        public System.Windows.Forms.DateTimePicker lunchStart;
        public System.Windows.Forms.DateTimePicker lunchEnd;
        public System.Windows.Forms.DateTimePicker end;
    };

    // Week structure
    public struct week
    {
        public week(day arg0, day arg1, day arg2, day arg3, day arg4)
        {
            monday = arg0;
            tuesday = arg1;
            wednesday = arg2;
            thursday = arg3;
            friday = arg4;
            days = new List<day> { monday, tuesday, wednesday, thursday, friday };
        }
        public void resetWeekTimes(config config)
        {
            foreach (var day in days )
            {
                day.start.Value = config.defaultStartOfDayTime;
                day.lunchStart.Value = config.defaultLunchStartTime;
                day.lunchEnd.Value = config.defaultLunchEndTime;
                day.end.Value = config.defaultEndOfDayTime;
            }
        }
        public day monday;
        public day tuesday;
        public day wednesday;
        public day thursday;
        public day friday;
        List<day> days;
    };

    // Configuration settings structure
    public struct config
    {
        public config(System.DateTime arg0, System.DateTime arg1, System.DateTime arg2, System.DateTime arg3, bool arg4, bool arg5)
        {
            defaultStartOfDayTime = arg0;
            defaultLunchStartTime = arg1;
            defaultLunchEndTime = arg2;
            defaultEndOfDayTime = arg3;
            defaultCarryOverHours = 0.0; // This should always be 0.0
            twoWeekCycleEnabled = arg4;
            ignoreCarryOverHours = arg5;
        }
        public System.DateTime defaultStartOfDayTime;
        public System.DateTime defaultLunchStartTime;
        public System.DateTime defaultLunchEndTime;
        public System.DateTime defaultEndOfDayTime;
        public double defaultCarryOverHours;
        public bool twoWeekCycleEnabled;
        public bool ignoreCarryOverHours;
    };



    // Do generic things like load files
    class Helpers
    {
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
                // This is where the default settings are initialized if they have not been previously modified
                config default_settings = new config(
                    stringToTime("08:00:00"),
                    stringToTime("12:00:00"),
                    stringToTime("13:00:00"),
                    stringToTime("17:00:00"),
                    true,
                    false);
                return default_settings;
            }
            else
            {
                config loaded_settings = new config(
                    stringToTime(settingsIn[0]),
                    stringToTime(settingsIn[1]),
                    stringToTime(settingsIn[2]),
                    stringToTime(settingsIn[3]),
                    Convert.ToBoolean(settingsIn[4]),
                    Convert.ToBoolean(settingsIn[5]));
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
            return dateTime.ToString("hh:mm:ss  tt");
        }

        public System.DateTime stringToTime(string time)
        {
            // Get formatted time
            return DateTime.Parse(time);
        }
    }

    public static class Extensions
    {
        public static System.DateTime Time(this System.Windows.Forms.DateTimePicker dateTime)
        {
            // This renames the .Value() method of a DateTimePicker to be more clear
            return dateTime.Value;
        }
    }   
}
