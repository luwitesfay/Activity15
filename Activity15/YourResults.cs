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
    public partial class YourResults : Form
    {
        public YourResults()
        {
            InitializeComponent();
        }

        //Show the rondomly generated lucky number on a new page
        private void YourResults_Load(object sender, EventArgs e)
        {
            LuckyNumbers yourNumerIs = new LuckyNumbers();
            YourLuckyNumIs.Text = yourNumerIs.rtnluckyNumber().ToString();
        }
    }
}
