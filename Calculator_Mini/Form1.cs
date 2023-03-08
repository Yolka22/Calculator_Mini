using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Mini
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculate_Button_Click(object sender, EventArgs e)
        {

            int number1 = Convert.ToInt32(Number1_Text.Text);
            int number2 = Convert.ToInt32(Number2_Text.Text);
            float result = 0;

            if (Divide_Radio.Checked == true)
            {
                result = number1/ number2;
            }

            if (Multiply_Radio.Checked == true)
            {
                 result = number1 * number2;
            }

            if (Plus_Radio.Checked == true)
            {
                 result = number1 + number2;
            }

            if (Minus_radio.Checked == true)
            {
                 result = number1 - number2;
            }

            MessageBox.Show("результат = " + result);
        }
    }
}
