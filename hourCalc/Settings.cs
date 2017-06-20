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
    public partial class Settings : Form
    {
        public Settings(hourCalc form)
        {
            InitializeComponent();
            hourCalcRef = form;
        }

        // Keep an instance of the parent form / class hourCalc
        private hourCalc hourCalcRef;
        private Helpers Helper;
        private config settings;

        private System.Collections.Generic.Dictionary<string, int> dataMap = new System.Collections.Generic.Dictionary<string, int>()
        {
            { "StartOfDayTime", 0 },
            { "LunchStartTime", 1 },
            { "LunchEndTime", 2 },
            { "EndOfDayTime", 3 },
            { "checkBoxTwoWeekCycle", 4 },
            { "checkBoxIgnoreCarryOver", 5 }
        };

        private void Settings_Load(object sender, EventArgs e)
        {
            // Create Helpers instance
            Helper = new Helpers();

            // Load Settingss
            settings = Helper.getSettings();

            // Load current settings from file when setting page loads
            var dataIn = Helper.readFile("HC_Settings.dat");

            // Iterate through settings and try to set them with values from file
            int counter = 0;
            foreach (System.Windows.Forms.Control control in this.Controls)
            {
                // If setting is a time value (dateTimePicker)
                if (control is System.Windows.Forms.DateTimePicker)
                {
                    int index = dataMap[control.Name];
                    if (dataIn.Length > index)
                    {
                        // Set with file value
                        System.Console.WriteLine("Loading saved value for index: {0}", index);
                        ((System.Windows.Forms.DateTimePicker)control).Value = Helper.getTime(dataIn[index]);
                    }
                    else
                    {
                        if (counter == 0) // Start of day time, set to 8:00 AM
                        {
                            ((System.Windows.Forms.DateTimePicker)control).Value = settings.defaultStartOfDay();
                        }
                        if (counter == 1) // Start of lunch time, set to 12:00 PM
                        {
                            ((System.Windows.Forms.DateTimePicker)control).Value = settings.defaultLunchStart();
                        }
                        if (counter == 2) // End of lunch time, set to 01:00 PM
                        {
                            ((System.Windows.Forms.DateTimePicker)control).Value = settings.defaultLunchEnd();
                        }
                        if (counter == 3) // End of day time, set to 05:00 PM
                        {
                            ((System.Windows.Forms.DateTimePicker)control).Value = settings.defaultEndOfDay();
                        }
                        System.Console.WriteLine("Setting min-value for index: {0}", index);
                    }
                    counter++;
                }

                // If setting is a boolean value (checkBox)
                else if (control is System.Windows.Forms.CheckBox)
                {
                    int index = dataMap[control.Name];
                    if (dataIn.Length > index)
                    {
                        // Set with file value
                        System.Console.WriteLine("Loading saved value for index: {0}", index);
                        ((System.Windows.Forms.CheckBox)control).Checked = Convert.ToBoolean(dataIn[index]);
                    }
                    else
                    {
                        if (control.Name == "checkBoxIgnoreCarryOver")
                        {
                            ((System.Windows.Forms.CheckBox)control).Checked = false;
                        }
                        else
                        {
                            ((System.Windows.Forms.CheckBox)control).Checked = true;
                        }
                    }
                }
            }

            // Disable the Apply button until settings have been changed
            buttonApply.Enabled = false;
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            // Save settings
            System.IO.StreamWriter file = new System.IO.StreamWriter("HC_Settings.dat");

            // Save default times
            foreach (System.Windows.Forms.Control control in this.Controls)
            {
                if (control is System.Windows.Forms.DateTimePicker)
                {
                    // Write the string to a file.
                    System.Console.WriteLine("Saved time for {0}", control.Name);
                    System.DateTime dateTime = ((System.Windows.Forms.DateTimePicker)control).Value;
                    file.WriteLine(Helper.formatTime(dateTime));
                }
            }
            // Save two week cycle setting
            bool twoWeekCycle = checkBoxTwoWeekCycle.Checked;
            file.WriteLine(twoWeekCycle);

            // Save ignore carry over hours setting
            bool ignoreCarryOver = checkBoxIgnoreCarryOver.Checked;
            file.WriteLine(ignoreCarryOver);
            file.Close();

            //Apply new settings to the main page
            hourCalcRef.loadData();

            // Disable the Apply button until settings have been changed
            buttonApply.Enabled = false;

            MessageBox.Show("Settings Updated!", "Doble Hour Calculator");
        }

        private void StartOfDayTime_ValueChanged(object sender, EventArgs e)
        {
            buttonApply.Enabled = true;
        }

        private void LunchStartTime_ValueChanged(object sender, EventArgs e)
        {
            buttonApply.Enabled = true;
        }

        private void LunchEndTime_ValueChanged(object sender, EventArgs e)
        {
            buttonApply.Enabled = true;
        }

        private void EndOfDayTime_ValueChanged(object sender, EventArgs e)
        {
            buttonApply.Enabled = true;
        }

        private void checkBoxTwoWeekCycle_CheckedChanged(object sender, EventArgs e)
        {
            buttonApply.Enabled = true;
        }

        private void checkBoxIgnoreCarryOver_CheckedChanged(object sender, EventArgs e)
        {
            buttonApply.Enabled = true;
        }
    }
}
