using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitSample
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int leftValue = int.Parse(txtExpression1.Text);
            int rightValue = int.Parse(txtExpression2.Text);
            txtResult.Text = (leftValue + rightValue).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int leftValue = int.Parse(txtExpression1.Text);
            int rightValue = int.Parse(txtExpression2.Text);
            txtResult.Text = (leftValue - rightValue).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int leftValue = int.Parse(txtExpression1.Text);
            int rightValue = int.Parse(txtExpression2.Text);
            txtResult.Text = (leftValue * rightValue).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //あえて指摘を受けよう
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double leftValue = double.Parse(txtExpression1.Text);
            double rightValue = double.Parse(txtExpression2.Text);
            txtResult.Text = (leftValue / rightValue).ToString();
        }
    }
}
