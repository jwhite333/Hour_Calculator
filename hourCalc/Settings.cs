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
        // Keep an instance of the parent form / class hourCalc
        private hourCalc hourCalcRef;

        public Settings(hourCalc form)
        {
            InitializeComponent();
            hourCalcRef = form;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            // Load current settings from file when setting page loads
            System.Collections.Generic.List<string> lineList = new System.Collections.Generic.List<string>();
            System.IO.FileStream fileStream = new System.IO.FileStream("HC_Settings.dat", System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Read);
            using (var streamReader = new System.IO.StreamReader(fileStream))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    lineList.Add(line);
                }
            }
            fileStream.Close();
            var settingsIn = lineList.ToArray();

            // Iterate through settings and try to set them with values from file
            int counter = 0;
            foreach (System.Windows.Forms.Control control in this.Controls)
            {
                // If setting is a time value (dateTimePicker)
                if (control is System.Windows.Forms.DateTimePicker)
                {
                    int index = settingsMap[control.Name];
                    if (settingsIn.Length > index)
                    {
                        // Set with file value
                        System.Console.WriteLine("Loading saved value for index: {0}", index);
                        ((System.Windows.Forms.DateTimePicker)control).Value = hourCalcRef.getTime(settingsIn[index]);
                    }
                    else
                    {
                        if (counter == 0) // Start of day time, set to 8:00 AM
                        {
                            ((System.Windows.Forms.DateTimePicker)control).Value = hourCalcRef.getTime("08:00:00");
                        }
                        if (counter == 1) // Start of lunch time, set to 12:00 PM
                        {
                            ((System.Windows.Forms.DateTimePicker)control).Value = hourCalcRef.getTime("12:00:00");
                        }
                        if (counter == 2) // End of lunch time, set to 01:00 PM
                        {
                            ((System.Windows.Forms.DateTimePicker)control).Value = hourCalcRef.getTime("13:00:00");
                        }
                        if (counter == 3) // End of day time, set to 05:00 PM
                        {
                            ((System.Windows.Forms.DateTimePicker)control).Value = hourCalcRef.getTime("17:00:00");
                        }
                        System.Console.WriteLine("Setting min-value for index: {0}", index);
                    }
                    counter++;
                }

                // If setting is a boolean value (checkBox)
                else if (control is System.Windows.Forms.CheckBox)
                {
                    int index = settingsMap[control.Name];
                    if (settingsIn.Length > index)
                    {
                        // Set with file value
                        System.Console.WriteLine("Loading saved value for index: {0}", index);
                        ((System.Windows.Forms.CheckBox)control).Checked = Convert.ToBoolean(settingsIn[index]);
                    }
                    else
                    {
                        ((System.Windows.Forms.CheckBox)control).Checked = true;
                    }
                }
            }

            // Disable the Apply button until settings have been changed
            buttonApply.Enabled = false;
        }

        private System.Collections.Generic.Dictionary<string, int> settingsMap = new System.Collections.Generic.Dictionary<string, int>()
        {
            { "StartOfDayTime", 0 },
            { "LunchStartTime", 1 },
            { "LunchEndTime", 2 },
            { "EndOfDayTime", 3 },
            { "checkBoxTwoWeekCycle", 4 }
        };

        private void buttonApply_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Settings Updated!", "Doble Hour Calculator");

            System.IO.StreamWriter file = new System.IO.StreamWriter("HC_Settings.dat");

            // Save default times
            foreach (System.Windows.Forms.Control control in this.Controls)
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

            // Save two week cycle setting
            bool twoWeekCycle = checkBoxTwoWeekCycle.Checked;
            file.WriteLine(twoWeekCycle);
            file.Close();

            // Disable the Apply button until settings have been changed
            buttonApply.Enabled = false;
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
    }
}
