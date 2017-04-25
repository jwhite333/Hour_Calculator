using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hourCalc
{
    public partial class hourCalc : Form
    {
        public hourCalc()
        {
            InitializeComponent();
            loadData();
        }

        /*public string formatTime(string time)
        {
            //Get rid of date
            int firstSpaceIndex = time.IndexOf(" ");
            string subStr = time.Substring(firstSpaceIndex, (time.Length - firstSpaceIndex));

            //Get rid of AM/PM specifier
            return subStr.Substring(0, (subStr.Length - 3));
        }*/

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

        public double getDepartTime(string day)
        {
            double result = 0.0;
            switch (day)
            {
                case "Monday":
                    {
                        double morningHours = (timeToNum(monLunchStartTime.Value) - timeToNum(monStartTime.Value));
                        double afternoonHours = (timeToNum(monEndTime.Value) - timeToNum(monLunchEndTime.Value));
                        if (morningHours < 0 || afternoonHours < 0)
                        {
                            MessageBox.Show("Undefined Result, check that time values are chronological", "Doble Hour Calculator");
                            return -1.0;
                        }
                        result = 8 - (morningHours + afternoonHours);
                        //result += timeToNum(monEndTime.Value);
                    }
                    break;
                case "Tuesday":
                    {
                        double morningHours = (timeToNum(tueLunchStartTime.Value) - timeToNum(tueStartTime.Value));
                        double afternoonHours = (timeToNum(tueEndTime.Value) - timeToNum(tueLunchEndTime.Value));
                        if (morningHours < 0 || afternoonHours < 0)
                        {
                            MessageBox.Show("Undefined Result, check that time values are chronological");
                            return -1.0;
                        }
                        result = 8 - (morningHours + afternoonHours);
                        //result += timeToNum(tueEndTime.Value);
                    }
                    break;
                case "Wednesday":
                    {
                        double morningHours = (timeToNum(wedLunchStartTime.Value) - timeToNum(wedStartTime.Value));
                        double afternoonHours = (timeToNum(wedEndTime.Value) - timeToNum(wedLunchEndTime.Value));
                        if (morningHours < 0 || afternoonHours < 0)
                        {
                            MessageBox.Show("Undefined Result, check that time values are chronological");
                            return -1.0;
                        }
                        result = 8 - (morningHours + afternoonHours);
                        //result += timeToNum(wedEndTime.Value);
                    }
                    break;
                case "Thursday":
                    {
                        double morningHours = (timeToNum(thuLunchStartTime.Value) - timeToNum(thuStartTime.Value));
                        double afternoonHours = (timeToNum(thuEndTime.Value) - timeToNum(thuLunchEndTime.Value));
                        if (morningHours < 0 || afternoonHours < 0)
                        {
                            MessageBox.Show("Undefined Result, check that time values are chronological");
                            return -1.0;
                        }
                        result = 8 - (morningHours + afternoonHours);
                        //result += timeToNum(thuEndTime.Value);
                    }
                    break;
                case "Friday":
                    {
                        double morningHours = (timeToNum(friLunchStartTime.Value) - timeToNum(friStartTime.Value));
                        double afternoonHours = (timeToNum(friEndTime.Value) - timeToNum(friLunchEndTime.Value));
                        if (morningHours < 0 || afternoonHours < 0)
                        {
                            MessageBox.Show("Undefined Result, check that time values are chronological");
                            return -1.0;
                        }
                        result = 8 - (morningHours + afternoonHours);
                        //result += timeToNum(friEndTime.Value);
                    }
                    break;
                default:
                    {
                        MessageBox.Show("Undefined Result, check that time values are chronological");
                        return -1.0;
                    }
            }
            return result;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved!", "Doble Hour Calculator");

            System.IO.StreamWriter file = new System.IO.StreamWriter("dateStorage.dat");
            foreach (System.Windows.Forms.Control control in this.tableLayoutPanel1.Controls)
                {
                if (control is System.Windows.Forms.DateTimePicker)
                {
                    // Write the string to a file.
                    System.Console.WriteLine("Saved time for {0}", control.Name);
                    System.DateTime dateTime = ((System.Windows.Forms.DateTimePicker)control).Value;
                    string hours = dateTime.Hour.ToString();
                    if (hours.Length == 1)
                        hours = hours.Insert(0, "0");
                    string minutes = dateTime.Minute.ToString();
                    if (minutes.Length == 1)
                        minutes = minutes.Insert(0, "0");
                    string seconds = dateTime.Second.ToString();
                    if (seconds.Length == 1)
                        seconds = seconds.Insert(0, "0");
                    file.WriteLine(hours + ":" + minutes + ":" + seconds);
                }
            }
            file.Close();
        }

        private void buttonCalcDay_Click(object sender, EventArgs e)
        {
            // Get departure time for a specific day
            string day = this.comboBoxSelectDay.SelectedItem.ToString();
            double result = getDepartTime(day);

            switch (day)
            {
                case "Monday":
                    {
                        result += timeToNum(monEndTime.Value);
                    }
                    break;
                case "Tuesday":
                    {
                        result += timeToNum(tueEndTime.Value);
                    }
                    break;
                case "Wednesday":
                    {
                        result += timeToNum(wedEndTime.Value);
                    }
                    break;
                case "Thursday":
                    {
                        result += timeToNum(thuEndTime.Value);
                    }
                    break;
                case "Friday":
                    {
                        result += timeToNum(friEndTime.Value);
                    }
                    break;
            }
            
            // Set value
            System.DateTime Time = numToTime(result);
            this.calcDprtDayOutput.Text = timeToString(Time);
        }

        private void buttonCalcWeek_Click(object sender, EventArgs e)
        {
            double monResult = getDepartTime("Monday");
            double tueResult = getDepartTime("Tuesday");
            double wedResult = getDepartTime("Wednesday");
            double thuResult = getDepartTime("Thursday");
            double friResult = getDepartTime("Friday");
            double result = monResult + tueResult + wedResult + thuResult + friResult + timeToNum(friEndTime.Value);

            // Set value
            System.DateTime Time = numToTime(result);
            this.calcDprtFriOutput.Text = timeToString(Time);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            // Check if the user actually wanted to clear the table
            string message = "Did you really want to clear the table?";
            string caption = "Doble Hour Calculator";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                // Clear Data file
                System.IO.FileStream fileStream = new System.IO.FileStream("dateStorage.dat", System.IO.FileMode.Truncate);
                fileStream.Close();
                this.loadData();
            }
            else
                return;
        }
    }
}
