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
    public partial class password : Form
    {
        public password()
        {
            InitializeComponent();
            this.ActiveControl = txtBoxPassword;
        }
        public static string Show()
        {
            using (password inputDig = new password())
            {
                inputDig.ShowDialog();
                return inputDig.txtBoxPassword.Text;
            }
        }
    }
}
