using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txtbox_FirstValue.Text);
            float b = float.Parse(txtbox_SecondValue.Text);

            var c = a + b;
            txtbox_Result.Text = c.ToString(CultureInfo.InvariantCulture);
        }

        private void btn_Subtract_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txtbox_FirstValue.Text);
            float b = float.Parse(txtbox_SecondValue.Text);

            var c = a - b;
            txtbox_Result.Text = c.ToString(CultureInfo.InvariantCulture);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtbox_FirstValue.Text="";
            txtbox_SecondValue.Text = "";
            txtbox_Result.Text = "";
        }

        private void btn_Multiply_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txtbox_FirstValue.Text);
            float b = float.Parse(txtbox_SecondValue.Text);

            var c = a * b;
            txtbox_Result.Text = c.ToString(CultureInfo.InvariantCulture);
        }

        private void btn_Divide_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txtbox_FirstValue.Text);
            float b = float.Parse(txtbox_SecondValue.Text);

            var c = a / b;
            txtbox_Result.Text = c.ToString(CultureInfo.InvariantCulture);
        }
    }
}
