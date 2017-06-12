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

        // My Additions
        private System.Collections.Generic.Dictionary<string, int> timeMap = new System.Collections.Generic.Dictionary<string, int>()
        {
            { "monStartTime", 0 },
            { "tueStartTime", 1 },
            { "wedStartTime", 2 },
            { "thuStartTime", 3 },
            { "friStartTime", 4 },
            { "monLunchStartTime", 5 },
            { "tueLunchStartTime", 6 },
            { "wedLunchStartTime", 7 },
            { "thuLunchStartTime", 8 },
            { "friLunchStartTime", 9 },
            { "monLunchEndTime", 10 },
            { "tueLunchEndTime",  11},
            { "wedLunchEndTime", 12 },
            { "thuLunchEndTime", 13 },
            { "friLunchEndTime", 14 },
            { "monEndTime", 15 },
            { "tueEndTime", 16 },
            { "wedEndTime", 17 },
            { "thuEndTime", 18 },
            { "friEndTime", 19 }
        };

        private Helpers.config settings;
        private Helpers Helper;
        Settings settingsForm;

        public void loadData()
        {
            // Create Helpers instance
            Helper = new Helpers();

            // Load settings
            settingsForm = new Settings(this);
            settings = Helper.getSettings();

            var timesIn = Helper.readFile("HC_Data.dat");

            // Iterate through times and try to set them with values from file
            int counter = 0;
            foreach (System.Windows.Forms.Control control in this.tableLayoutPanel1.Controls)
            {
                if (control is System.Windows.Forms.DateTimePicker)
                {
                    int index = timeMap[control.Name];
                    if (timesIn.Length > index)
                    {
                        // Set with file value
                        System.Console.WriteLine("Loading saved value for index: {0}", index);
                        ((System.Windows.Forms.DateTimePicker)control).Value = Helper.getTime(timesIn[index]);
                    }
                    else
                    {
                        if (counter >= 0 && counter < 5) // Start of day time, set to 8:00 AM
                        {
                            ((System.Windows.Forms.DateTimePicker)control).Value = settings.defaultStartOfDay();
                        }
                        if (counter >= 5 && counter < 10) // Start of lunch time, set to 12:00 PM
                        {
                            ((System.Windows.Forms.DateTimePicker)control).Value = settings.defaultLunchStart();
                        }
                        if (counter >= 10 && counter < 15) // End of lunch time, set to 01:00 PM
                        {
                            ((System.Windows.Forms.DateTimePicker)control).Value = settings.defaultLunchEnd();
                        }
                        if (counter >= 15 && counter < 20) // End of day time, set to 05:00 PM
                        {
                            ((System.Windows.Forms.DateTimePicker)control).Value = settings.defaultEndOfDay();
                        }
                        System.Console.WriteLine("Setting min-value for index: {0}", index);
                    }
                    counter++;
                }
            }
        }

        public double getDepartTime(string day)
        {
            double result = 0.0;
            switch (day)
            {
                case "Monday":
                    {
                        double morningHours = (Helper.timeToNum(monLunchStartTime.Value) - Helper.timeToNum(monStartTime.Value));
                        double afternoonHours = (Helper.timeToNum(monEndTime.Value) - Helper.timeToNum(monLunchEndTime.Value));
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
                        double morningHours = (Helper.timeToNum(tueLunchStartTime.Value) - Helper.timeToNum(tueStartTime.Value));
                        double afternoonHours = (Helper.timeToNum(tueEndTime.Value) - Helper.timeToNum(tueLunchEndTime.Value));
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
                        double morningHours = (Helper.timeToNum(wedLunchStartTime.Value) - Helper.timeToNum(wedStartTime.Value));
                        double afternoonHours = (Helper.timeToNum(wedEndTime.Value) - Helper.timeToNum(wedLunchEndTime.Value));
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
                        double morningHours = (Helper.timeToNum(thuLunchStartTime.Value) - Helper.timeToNum(thuStartTime.Value));
                        double afternoonHours = (Helper.timeToNum(thuEndTime.Value) - Helper.timeToNum(thuLunchEndTime.Value));
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
                        double morningHours = (Helper.timeToNum(friLunchStartTime.Value) - Helper.timeToNum(friStartTime.Value));
                        double afternoonHours = (Helper.timeToNum(friEndTime.Value) - Helper.timeToNum(friLunchEndTime.Value));
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

            System.IO.StreamWriter file = new System.IO.StreamWriter("HC_Data.dat");
            foreach (System.Windows.Forms.Control control in this.tableLayoutPanel1.Controls)
                {
                if (control is System.Windows.Forms.DateTimePicker)
                {
                    // Write the string to a file.
                    System.Console.WriteLine("Saved time for {0}", control.Name);
                    System.DateTime dateTime = ((System.Windows.Forms.DateTimePicker)control).Value;
                    file.WriteLine(Helper.formatTime(dateTime));
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
                        result += Helper.timeToNum(monEndTime.Value);
                    }
                    break;
                case "Tuesday":
                    {
                        result += Helper.timeToNum(tueEndTime.Value);
                    }
                    break;
                case "Wednesday":
                    {
                        result += Helper.timeToNum(wedEndTime.Value);
                    }
                    break;
                case "Thursday":
                    {
                        result += Helper.timeToNum(thuEndTime.Value);
                    }
                    break;
                case "Friday":
                    {
                        result += Helper.timeToNum(friEndTime.Value);
                    }
                    break;
            }
            
            // Set value
            System.DateTime Time = Helper.numToTime(result);
            this.calcDprtDayOutput.Text = Helper.timeToString(Time);
        }

        private void buttonCalcWeek_Click(object sender, EventArgs e)
        {
            double monResult = getDepartTime("Monday");
            double tueResult = getDepartTime("Tuesday");
            double wedResult = getDepartTime("Wednesday");
            double thuResult = getDepartTime("Thursday");
            double friResult = getDepartTime("Friday");
            double result = monResult + tueResult + wedResult + thuResult + friResult + Helper.timeToNum(friEndTime.Value);

            // Set value
            System.DateTime Time = Helper.numToTime(result);
            this.calcDprtFriOutput.Text = Helper.timeToString(Time);
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
                System.IO.FileStream fileStream = new System.IO.FileStream("HC_Data.dat", System.IO.FileMode.Truncate);
                fileStream.Close();
                this.loadData();
            }
            else
                return;
        }

        private void ConfigButton_Click(object sender, EventArgs e)
        {
            // Load a new form that shows configuration data
            settingsForm.Show();
        }
    }
}
