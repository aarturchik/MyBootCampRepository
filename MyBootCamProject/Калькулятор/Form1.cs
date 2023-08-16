using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор
{
    public partial class Form1 : Form
    {
        int counter = 0;
        
        public Form1()
        {
            InitializeComponent();
            lblName3.Text = counter.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblName1.Text = "Hello world";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnName1_Click(object sender, EventArgs e)
        {
            lblName2.Text = "Artur";
        }

        private void btnName2_Click(object sender, EventArgs e)
        {
            counter++;
            lblName3.Text = counter.ToString();
        }
    }
}
