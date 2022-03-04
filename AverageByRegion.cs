//Author: Honore Signe Signe
// Created: March 1, 2022
// Modified: March 4, 2022
// Description:
// A simple program that takes 21 inputs from the user and calculates
// a set of averages over 3 regions and 7 days. When all
// 21 inputs have been accepted as valid whole numbers, an overall
// average is determined and displayed.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class AverageByRegion : Form
    {
        // Declare the number of regions and number of days
        const int MaxDays = 7;
        const int MaxRegions = 3;
        const int MaxUnits = 5000;

        // Declare an array to contail all of the inputs.
        int[,] units = new int[MaxRegions, MaxDays];

        // Declare array of controls that exist for each region.
        TextBox[] outputTextboxes = new TextBox[MaxRegions];
        Label[] outputAverageLabels = new Label[MaxRegions];

        // Declare class-level variables for the current day and region
        int day = 0;
        int region = 0;

        // Declare variable for the region average and the overall average
        double sum = 0;
        double overallAverage = 0;

        public AverageByRegion()
        {
            InitializeComponent();

            outputTextboxes = new TextBox[] { textBoxEntriesRegion1, textBoxEntriesRegion2, textBoxEntriesRegion3 };
            outputAverageLabels = new Label[] { labelAverageRegion1, labelAverageRegion2, labelAverageRegion3 };

        }

        /// <summary>
        /// Close the application
        /// </summary>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Clear all the fields of the form
        /// </summary>
        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxEntriesRegion1.Clear();
            textBoxEntriesRegion2.Clear();
            textBoxEntriesRegion3.Clear();
            textBoxUnits.Clear();
            labelAverageRegion1.Text = "";
            labelAverageRegion2.Text = "";
            labelAverageRegion3.Text = "";
            labelOverallAverage.Text = "";

            // Reset the variables
            day = 0;
            region = 0;
            overallAverage = 0;
            sum = 0;

            // Reset the day label
            labelDay.Text = "Day " + (day + 1);

            // Enable disabled controls
            // Make the entry textbox not to be ReadOnly
            textBoxUnits.ReadOnly = false;
            // Enable the Enter button
            buttonEnter.Enabled = true;
            // set the focus
            textBoxUnits.Focus();
        }

        // Validate input and store in a textbox
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            //const int MinimumUnits = 0;
            //const int MaximumDays = 7;

            int entry;
            double average = 0;

            // Check if the input is a whole number
            if (int.TryParse(textBoxUnits.Text, out entry))
            {
                // Check if input is in the valid range
                if (entry >= 0 && entry <= MaxUnits)
                {
                    sum += entry;
                    // If the entry is valid
                    units[region, day] = entry;
                    // Add the entry to the textBoxEntries
                    outputTextboxes[region].Text += entry + Environment.NewLine;
                    
                    textBoxUnits.Clear();
                    // Increment the labelDay by 1
                    day++;
                    // If day equal 7, find the average
                    if (day >= MaxDays)
                    {
                        average = Math.Round(sum / MaxDays, 2);
                        outputAverageLabels[region].Text = ("Average: ") + average.ToString();
                        overallAverage += average;
                        // Reset the day to 0 and increment the region by 1.
                        day = 0;
                        region++;
                        labelDay.Text = "Day " + (day + 1);
                        sum = 0;

                    }
                    else
                    {
                        labelDay.Text = "Day " + (day + 1);
                    }
                    if (region >= 3)
                    {
                        overallAverage = Math.Round(overallAverage / MaxRegions, 2);
                        labelOverallAverage.Text = "Average this week: " + overallAverage.ToString();

                        // Make the entry textbox ReadOnly
                        textBoxUnits.ReadOnly = true;
                        // Make the Enter button Disabled
                        buttonEnter.Enabled = false;
                    }

                }
                // If the entry is not in a valid range, display an error message
                else
                {
                    MessageBox.Show("Please enter a number in a range of 0 to " + MaxUnits + ". Entry Error");
                }
            }
            // If the entry is not numeric, display an error message
            else
            {
                MessageBox.Show("Please enter a numeric number");
            }
            
        }
    }
}
