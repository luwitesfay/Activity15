using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity15
{
    public partial class LuckyNumbers : Form
    {

        //Intialization
        int numOfDays;
        static int luckyNumber;
        public LuckyNumbers()
        {
            InitializeComponent();
        }
        //return the lucky number
        public int rtnluckyNumber()
        {
            return luckyNumber;
        }

        //Method to open your results page on click of button as long as the user selection fields are not empty
        private void LuckyButton_Click(object sender, EventArgs e)
        {
                //Check if the fields are empty and generat a lucky number when your enters birth information
                if (birthDayCB.SelectedIndex != -1 && birthMonthCB.SelectedIndex != -1 && birthYearCB.SelectedIndex != -1 && favoriteColorCB.SelectedIndex != -1)
                {
                    luckyNumber = (birthDayCB.SelectedIndex + birthMonthCB.SelectedIndex + birthYearCB.SelectedIndex + favoriteColorCB.SelectedIndex);
                    YourResults yourResults = new YourResults();
                    yourResults.Show();
                    this.Hide();

                //send error message if one or more fields are empty
                }else
                { 
                MessageBox.Show("One or more sections are empty. Please fill the above form");
                }
                
        }

        //
        public void birthDayInfo()
        {
            numOfDays = 0;
            //Set the moths to 31 days based on the index
            if (birthDayCB.SelectedIndex == 0 || birthMonthCB.SelectedIndex == 2 || birthMonthCB.SelectedIndex == 4
                || birthMonthCB.SelectedIndex == 6 || birthMonthCB.SelectedIndex == 7 || birthMonthCB.SelectedIndex == 9
                || birthMonthCB.SelectedIndex == 11)
            {
                numOfDays = 31;
            }

            //Update the days for february based on if it is a lip year or not
            else if (birthMonthCB.SelectedIndex == 1)
            {
                int birthYear = Int32.Parse(birthYearCB.Text);

                //Check if it is a leap year
                if (birthYear % 4 == 0)
                {
                    numOfDays = 29;
                }
                else
                {
                    numOfDays = 28;
                }
            }

            //Update the rest of the months to 30days
            else
            {
                numOfDays = 30;
            }

            //Update the days as long as month is not empty
            if (birthMonthCB.SelectedIndex != -1)
            {
                birthDayCB.Items.Clear();
                for (int i = 0; i < numOfDays; i++)
                {
                    birthDayCB.Items.Add(i + 1);
                }
                birthDayCB.Text = numOfDays.ToString();
            }
        }

        private void birthYearCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            birthDayInfo();
        }

        private void birthMonthCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            birthDayInfo();
        }


        //Update the year to show 2004 by default when the page loads
        private void LuckyNumbers_Load(object sender, EventArgs e)
        {
            birthYearCB.Text = "2004";
        }

    }
    

}


