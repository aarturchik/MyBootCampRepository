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
    public partial class Calculator : Form
    {
        private bool isNumber = false;
        private double numFirst;
        private double numSecond;
        private double numRes;




        public Calculator()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_keyDown(object sender, KeyEventArgs e)
        {
            isNumber = e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9
                || e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9
                || e.KeyCode == Keys.Back;

        }

        private void txt_keyPress(object sender, KeyPressEventArgs e)
        {
            TextBox box = (TextBox)sender;
            switch(e.KeyChar)
            {
                case '-':
                    if(box.Text.Length ==0)
                    {
                        isNumber = true;
                    }
                    break;

                case '.':
                case ',':
                    if(box.Text.Length == 0)
                    {
                        isNumber = false;
                        break;
                    }
                    if((box.Text[0] != '-' && box.Text.Length == 1 && !(box.Text.Contains('.') || box.Text.Contains('.'))) || (box.Text.Length == 2 & !(box.Text.Contains('.'))))
                    {
                        isNumber = true;
                        break;
                    }
                    break;
                case '!':
                case '@':
                case '#':
                case '$':
                case '%':
                case '^':
                case '&':
                case '*':
                case '(':
                case ')':
                case '"':
                case '№':
                case ';':
                case ':':
                case '?':
                    isNumber = false;
                    break;

            }
            if(!isNumber)
            {
                e.Handled = true;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string strfirst = string.Copy(txtBNumber1.Text);
            string strsecond = (txtBNumber2.Text);

            if(txtBNumber1.Text.Length > 0)
            {
                numFirst = Convert.ToDouble(strfirst);
            }
            else
            {
                numFirst = 0;
            }
            if (txtBNumber2.Text.Length > 0)
            {
                numSecond = Convert.ToDouble(strsecond);
            }
            else
            {
                numSecond = 0;
            }
            bool divideFlag = false;
            Button btn = (Button)sender;

            switch(btn.Name)
            {
                case "btnPlus":
                    numRes = numFirst + numSecond;
                    lblResalt.Text = numRes.ToString();
                    break;
                    
                case "btnMinus":
                    numRes = numFirst - numSecond;
                    lblResalt.Text = numRes.ToString();
                    break;

                case "btnMultiplay":
                    numRes = numFirst * numSecond;
                    lblResalt.Text = numRes.ToString();
                    break;

                case "btnDivide":
                    if(Math.Abs(numSecond) < 1.0E-30)
                    {
                        MessageBox.Show("Делить на ноль нельзя!", "Ошибка.",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    else
                    {
                        numRes = numFirst / numSecond;
                        lblResalt.Text = numRes.ToString();
                    }
                    break;
            }

            if(divideFlag)
            {
                lblResalt.Text = Convert.ToString(numRes);
            }
        }
    }
}
