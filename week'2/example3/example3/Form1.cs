using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void practiceButton_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "APDALLA AYAA LOO BADALAY MAGACA!";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
