using System.Text.RegularExpressions;

namespace Calculator
{
    public partial class Calculator : Form
    {
        float numProcess, ans;
        int count;
        bool IsCalculated = false;


        public Calculator()
        {
            InitializeComponent();
            disable();
        }

        public void disable()
        {
            tbResult.Enabled = false;
            tbProcess.Enabled = false;
            btClear.Enabled = false;
            btOff.Hide();
            btOn.Show();
            button0.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            buttonAddition.Enabled = false;
            buttonGange.Enabled = false;
            buttonMinus.Enabled = false;
            buttonDivision.Enabled = false;
            buttonfloat.Enabled = false;
            buttonEqueals.Enabled = false;
        }

        public void Enable()
        {
            tbResult.Enabled = true;
            tbProcess.Enabled = true;
            btClear.Enabled = true;
            btOff.Show();
            btOn.Hide();
            button0.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            buttonAddition.Enabled = true;
            buttonGange.Enabled = true;
            buttonMinus.Enabled = true;
            buttonDivision.Enabled = true;
            buttonfloat.Enabled = true;
            buttonEqueals.Enabled = true;
        }


        #region //button 1-9
        private void button0_Click(object sender, EventArgs e)
        {
            tbResult.Text += 0; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbResult.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbResult.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbResult.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tbResult.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tbResult.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tbResult.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tbResult.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tbResult.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tbResult.Text += 9;
        }
        #endregion

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            if (IsCalculated)
            {
                tbProcess.Clear();
                IsCalculated = false;
            }
            string result = Regex.Replace(tbResult.Text, "\r\n", string.Empty);
            numProcess = float.Parse(result);

            tbProcess.Text += $"{result} / ";
            tbResult.Clear();
            count = 4;
        }

        private void buttonGange_Click(object sender, EventArgs e)
        {
            if (IsCalculated)
            {
                tbProcess.Clear();
                IsCalculated = false;
            }
            string result = Regex.Replace(tbResult.Text, "\r\n", string.Empty);
            numProcess = float.Parse(result);

            tbProcess.Text += $"{result} * ";
            tbResult.Clear();
            count = 3;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (IsCalculated)
            {
                tbProcess.Clear();
                IsCalculated = false;
            }
            string result = Regex.Replace(tbResult.Text, "\r\n", string.Empty);
            numProcess = float.Parse(result);

            tbProcess.Text += $"{result} - ";
            tbResult.Clear();
            count = 2;
        }

        private void buttonAddition_Click(object sender, EventArgs e)
        {
            if (IsCalculated)
            {
                tbProcess.Clear();
                IsCalculated = false;
            }
            string result = Regex.Replace(tbResult.Text, "\r\n", string.Empty);
            numProcess = float.Parse(result);

            tbProcess.Text += $"{result} + ";
            tbResult.Clear();
            count = 1;
        }

        private void btOff_Click(object sender, EventArgs e)
        {
            disable();
        }

        private void btOn_Click(object sender, EventArgs e)
        {
            Enable();
        }

        private void buttonEqueals_Click(object sender, EventArgs e)
        {
            compute();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbResult.Clear();
            tbProcess.Clear();
        }

        private void compute()
        {
            switch (count)
            {
                case 1:
                    ans = numProcess + float.Parse(tbResult.Text);
                    tbProcess.Text += tbResult.Text;
                    tbResult.Text = ans.ToString();
                    break;
                case 2:
                    ans = numProcess - float.Parse(tbResult.Text);
                    tbProcess.Text += tbResult.Text;
                    tbResult.Text = ans.ToString();
                    break;
                case 3:
                    ans = numProcess * float.Parse(tbResult.Text);
                    tbProcess.Text += tbResult.Text;
                    tbResult.Text = ans.ToString();
                    break;
                case 4:
                    ans = numProcess / float.Parse(tbResult.Text);
                    tbProcess.Text += tbResult.Text;
                    tbResult.Text = ans.ToString();
                    break;
                default:
                    break;
            }
            IsCalculated = true;
        }
    }
}