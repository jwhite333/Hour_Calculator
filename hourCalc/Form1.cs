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
        }

        // Private globals
        private System.Collections.Generic.Dictionary<string, int> dataMap = new System.Collections.Generic.Dictionary<string, int>()
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
            { "friEndTime", 19 },
            { "textBoxCarryOverHours", 20 },
            { "weekNumber", 21 }
        };

        private week currentWeek;
        private config settings;
        private Helpers Helper;
        private double carryOverHours = 0.0;
        private int weekNumber = 1;

        private void hourCalc_Load(object sender, EventArgs e)
        {
            // Initialize days
            day monday = new day(monStartTime, monLunchStartTime, monLunchEndTime, monEndTime);
            day tuesday = new day(tueStartTime, tueLunchStartTime, tueLunchEndTime, tueEndTime);
            day wednesday = new day(wedStartTime, wedLunchStartTime, wedLunchEndTime, wedEndTime);
            day thursday = new day(thuStartTime, thuLunchStartTime, thuLunchEndTime, thuEndTime);
            day friday = new day(friStartTime, friLunchStartTime, friLunchEndTime, friEndTime);
            currentWeek = new week(monday, tuesday, wednesday, thursday, friday);

            // Load data
            loadData();
        }
        public void loadData()
        {
            // Create Helpers instance
            Helper = new Helpers();

            // Load settings
            settings = Helper.getSettings();

            var dataIn = Helper.readFile("HC_Data.dat");

            // Set comboBoxSelectDay to be the current day of the week
            System.DateTime today = System.DateTime.Now;
            string weekday = Convert.ToString(today.DayOfWeek);
            comboBoxSelectDay.SelectedItem = weekday;

            // Iterate through times and try to set them with values from file
            int counter = 0;
            foreach (System.Windows.Forms.Control control in this.tableLayoutPanel1.Controls)
            {
                if (control is System.Windows.Forms.DateTimePicker)
                {
                    int index = dataMap[control.Name];
                    if (dataIn.Length > index)
                    {
                        // Set with file value
                        System.Console.WriteLine("Loading saved value for item: {0}", control.Name);
                        ((System.Windows.Forms.DateTimePicker)control).Value = Helper.stringToTime(dataIn[index]);
                    }
                    else
                    {
                        if (counter >= 0 && counter < 5) // Start of day time, set to 8:00 AM
                        {
                            ((System.Windows.Forms.DateTimePicker)control).Value = settings.defaultStartOfDayTime;
                        }
                        if (counter >= 5 && counter < 10) // Start of lunch time, set to 12:00 PM
                        {
                            ((System.Windows.Forms.DateTimePicker)control).Value = settings.defaultLunchStartTime;
                        }
                        if (counter >= 10 && counter < 15) // End of lunch time, set to 01:00 PM
                        {
                            ((System.Windows.Forms.DateTimePicker)control).Value = settings.defaultLunchEndTime;
                        }
                        if (counter >= 15 && counter < 20) // End of day time, set to 05:00 PM
                        {
                            ((System.Windows.Forms.DateTimePicker)control).Value = settings.defaultEndOfDayTime;
                        }
                        System.Console.WriteLine("Setting default value for item: {0}", control.Name);
                    }
                    counter++;
                }
            }

            // Load the carry over hours
            int indexCarryOver = dataMap["textBoxCarryOverHours"];
            if (dataIn.Length > indexCarryOver)
            {
                // Set with file value
                System.Console.WriteLine("Loading saved value for item: {0}", "textBoxCarryOverHours");
                carryOverHours = Convert.ToDouble(dataIn[indexCarryOver]);
                if (carryOverHours == settings.defaultCarryOverHours)
                    labelCarryOverHours.Text = "Last Week Hours:";
                else if (carryOverHours > settings.defaultCarryOverHours)
                    labelCarryOverHours.Text = "Last Week Hours: ( Behind )";
                else
                    labelCarryOverHours.Text = "Last Week Hours: ( Ahead )";
                textBoxCarryOverHours.Text = Convert.ToString(Math.Abs(carryOverHours));
                
            }
            else
            {
                carryOverHours = settings.defaultCarryOverHours;
                labelCarryOverHours.Text = "Last Week Hours:";
                textBoxCarryOverHours.Text = Convert.ToString(carryOverHours);
                System.Console.WriteLine("Setting default value for item: {0}", "textBoxCarryOverHours");
            }

            // Load the week number
            int indexWeekNum = dataMap["weekNumber"];
            if (dataIn.Length > indexWeekNum)
            {
                // Set with file value
                System.Console.WriteLine("Loading saved value for item: {0}", "weekNumber");
                if (settings.twoWeekCycleEnabled)
                    labelWeekNumber.Text = "Week: " + dataIn[indexWeekNum] + " / 2";
                else
                    labelWeekNumber.Text = "Week: " + dataIn[indexWeekNum] + " / 1";
                weekNumber = Convert.ToInt32(dataIn[indexWeekNum]);
            }
            else
            {
                weekNumber = 1;
                System.Console.WriteLine("Setting default value for item: {0}", "weekNumber");
                if (settings.twoWeekCycleEnabled)
                    labelWeekNumber.Text = "Week: 1 / 2";
                else
                    labelWeekNumber.Text = "Week: 1 / 1";
            }
            
            // Set the ignore carry over hours field
            if (settings.ignoreCarryOverHours || !settings.twoWeekCycleEnabled)
            {
                textBoxCarryOverHours.Text = "Ignored";
            }
        }

        public double getDepartTimeOffsetWeek()
        {
            double offset = 0.0;
            offset += getDepartTimeOffsetDay(currentWeek.monday);
            offset += getDepartTimeOffsetDay(currentWeek.tuesday);
            offset += getDepartTimeOffsetDay(currentWeek.wednesday);
            offset += getDepartTimeOffsetDay(currentWeek.thursday);
            offset += getDepartTimeOffsetDay(currentWeek.friday);
            return offset;
        }

        public double getDepartTimeOffsetDay(day weekday)
        {
            double morningHours = (Helper.timeToNum(weekday.lunchStart.Time()) - Helper.timeToNum(weekday.start.Time()));
            double afternoonHours = (Helper.timeToNum(weekday.end.Time()) - Helper.timeToNum(weekday.lunchEnd.Time()));
            if (morningHours < 0 || afternoonHours < 0)
            {
                MessageBox.Show("Undefined Result, check that time values are chronological", "Doble Hour Calculator");
                return -1.0;
            }
            double result = 8 - (morningHours + afternoonHours); // Hours per day does not change at the moment
            return result;
        }

        public void saveData(bool userVisible)
        {
            if (userVisible)
            {
                MessageBox.Show("Saved!", "Doble Hour Calculator");
            }

            System.IO.StreamWriter file = new System.IO.StreamWriter("HC_Data.dat");
            foreach (System.Windows.Forms.Control control in this.tableLayoutPanel1.Controls)
            {
                if (control is System.Windows.Forms.DateTimePicker)
                {
                    // Write the string to a file.
                    System.Console.WriteLine("Saved time for {0}", control.Name);
                    System.DateTime dateTime = ((System.Windows.Forms.DateTimePicker)control).Value;
                    file.WriteLine(Helper.timeToString(dateTime));
                }
            }
            // Save carry over hours
            file.WriteLine(carryOverHours);
            System.Console.WriteLine("Saved carryOverHours");

            // Save week number
            file.WriteLine(weekNumber);
            System.Console.WriteLine("Saved weekNumber");

            file.Close();
        }

        public void clearDataFile()
        {
            // Clear Data file
            System.IO.FileStream fileStream = new System.IO.FileStream("HC_Data.dat", System.IO.FileMode.Truncate);
            fileStream.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Save and alert the user
            saveData(true);
        }

        private void buttonCalcDay_Click(object sender, EventArgs e)
        {
            // Get departure time for a specific day
            string day = this.comboBoxSelectDay.SelectedItem.ToString();
            double result = 0.0;

            switch (day)
            {
                case "Monday":
                    {
                        result = getDepartTimeOffsetDay(currentWeek.monday);
                        result += Helper.timeToNum(monEndTime.Value);
                    }
                    break;
                case "Tuesday":
                    {
                        result = getDepartTimeOffsetDay(currentWeek.tuesday);
                        result += Helper.timeToNum(tueEndTime.Value);
                    }
                    break;
                case "Wednesday":
                    {
                        result = getDepartTimeOffsetDay(currentWeek.wednesday);
                        result += Helper.timeToNum(wedEndTime.Value);
                    }
                    break;
                case "Thursday":
                    {
                        result = getDepartTimeOffsetDay(currentWeek.thursday);
                        result += Helper.timeToNum(thuEndTime.Value);
                    }
                    break;
                case "Friday":
                    {
                        result = getDepartTimeOffsetDay(currentWeek.friday);
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
            double result = getDepartTimeOffsetWeek() + Helper.timeToNum(friEndTime.Value);

            // If the past week hours have not been ignored, add them
            if (!settings.ignoreCarryOverHours && settings.twoWeekCycleEnabled)
            {
                result += carryOverHours;
            }

            // Set value
            System.DateTime Time = Helper.numToTime(result);
            this.calcDprtFriOutput.Text = Helper.timeToString(Time);
        }

        private void buttonNewWeek_Click(object sender, EventArgs e)
        {
            // Check if the user actually wanted to clear the table
            string message = "Did you really want to advance to another week? This will remove all data from the current table";
            string caption = "Doble Hour Calculator";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (settings.twoWeekCycleEnabled)
                {
                     // Two week cycle is enabled
                    switch (weekNumber)
                    {
                        case 1:
                            {
                                // Get carry over hours
                                weekNumber = 2;
                                carryOverHours = getDepartTimeOffsetWeek();

                                // Reset times for new week
                                currentWeek.resetWeekTimes(settings);
                                saveData(false); // Do not alert the user
                                break;
                            }
                        case 2:
                            {
                                // Load first week data from defaults
                                clearDataFile();
                                break;
                            }
                    }
                }
                else
                {
                    // Load new week data from defaults
                    clearDataFile();
                }

                // Load new data
                loadData();
            }
            else
                return;
        }

        private void ConfigButton_Click(object sender, EventArgs e)
        {
            // Load a new form that shows configuration data
            Settings settingsForm = new Settings(this);
            settingsForm.Show();
        }
    }
}
