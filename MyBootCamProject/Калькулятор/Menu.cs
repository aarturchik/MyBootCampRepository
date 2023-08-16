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
    public partial class Menu : Form
    {
        const string OurPassword = "12345";
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
        enterPassword:
            string Password = password.Show();
        if(Password == "")
            {
                this.Close();
            }
            if(Password != OurPassword && Password != "")
            {
                MessageBox.Show("Попробуйие ещё раз!", "Пароль неверный!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                goto enterPassword;
            }
        }

        private void lblLinkCalculator_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frn = new Calculator();
            frn.Show();
        }
    }
}
