using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public decimal Result { get; set; }
        public decimal Value { get; set; }
        private Operation OperationSeleted { get; set; }

        private enum Operation
        {
            Add,
            Sub,
            Mult,
            Div
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_0_Click(object sender, EventArgs e)
        {
            txt_result.Text += "0";
        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            txt_result.Text += "1";
        }
        private void Bt_5_Click(object sender, EventArgs e)
        {
            txt_result.Text += "5";
        }

        private void bt_div_Click(object sender, EventArgs e)
        {
            txt_result.Text += "/";
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            txt_result.Text += "8";
        }

        private void bt_7_Click_1(object sender, EventArgs e)
        {
            txt_result.Text += "7";
        }

        private void bt_result_Click(object sender, EventArgs e)
        {

        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (txt_result.Text.Length > 0)
            {
                txt_result.Text = txt_result.Text.Substring(0, txt_result.Text.Length - 1);
            }
        }

        private void bt_2_Click_1(object sender, EventArgs e)
        {
            txt_result.Text += "2";
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            txt_result.Text += "3";
        }

        private void bt_4_Click_1(object sender, EventArgs e)
        {
            txt_result.Text += "4";
        }

        private void bt_9_Click_1(object sender, EventArgs e)
        {
            txt_result.Text += "9";
        }

        private void bt_6_Click_1(object sender, EventArgs e)
        {
            txt_result.Text += "6";
        }

        private void bt_5_Click_1(object sender, EventArgs e)
        {
            txt_result.Text += "5";
        }

        private void bt_clear_Click_1(object sender, EventArgs e)
        {
            txt_result.Clear();
            Result = 0;
            Value = 0;
        }

        private void bt_sum_Click_1(object sender, EventArgs e)
        {
            OperationSeleted = Operation.Add;
            Value = Convert.ToDecimal(txt_result.Text);
            txt_result.Clear();
        }

        private void bt_sub_Click_1(object sender, EventArgs e)
        {
            OperationSeleted = Operation.Sub;
            Value = Convert.ToDecimal(txt_result.Text);
            txt_result.Clear();
        }

        private void bt_mult_Click_1(object sender, EventArgs e)
        {
            OperationSeleted = Operation.Mult;
            Value = Convert.ToDecimal(txt_result.Text);
            txt_result.Clear();
        }

        private void bt_div_Click_1(object sender, EventArgs e)
        {
            OperationSeleted = Operation.Div;
            Value = Convert.ToDecimal(txt_result.Text);
            txt_result.Clear();
        }

        private void bt_point_Click_1(object sender, EventArgs e)
        {
            txt_result.Text += ",";
        }
        private void DisplayResult(decimal result)
        {

            if (Math.Abs(result) >= 1e2m || (Math.Abs(result) > 0 && Math.Abs(result) < 1e-2m))
            {
                txt_result.Text = result.ToString("E2").Replace('E', 'e');
            }
            else
            {
                txt_result.Text = result.ToString();
            }
        }

        private void bt_result_Click_1(object sender, EventArgs e)
        {
            switch (OperationSeleted)
            {
                case Operation.Add:
                    Result = Value + Convert.ToDecimal(txt_result.Text);
                    DisplayResult(Result);
                    break;
                case Operation.Sub:
                    Result = Value - Convert.ToDecimal(txt_result.Text);
                    DisplayResult(Result);
                    break;
                case Operation.Div:
                    Result = Value / Convert.ToDecimal(txt_result.Text);
                    DisplayResult(Result);
                    break;
                case Operation.Mult:
                    Result = Value * Convert.ToDecimal(txt_result.Text);
                    DisplayResult(Result);
                    break;
            }
        }

        private void txt_result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
