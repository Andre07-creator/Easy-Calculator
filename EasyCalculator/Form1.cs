using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyCalculator
{
    public partial class Form1 : Form
    {
        double value1, value2, total;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                value1 = double.Parse(txbValue1.Text);
                value2 = double.Parse(txbValue2.Text);
                total = value1 + value2;
                txbTotal.Text = total.ToString();
                txbTotal.Show();

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void lbltotal_Click(object sender, EventArgs e)
        {

        }

        private void lblvalue1_Click(object sender, EventArgs e)
        {

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            try
            {
                value1 = double.Parse(txbValue1.Text);
                value2 = double.Parse(txbValue2.Text);
                total = value1 - value2;
                txbTotal.Text = total.ToString();
                txbTotal.Show();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            try
            {
                value1 = double.Parse(txbValue1.Text);
                value2 = double.Parse(txbValue2.Text);
                total = value1 * value2;
                txbTotal.Text = total.ToString();
                txbTotal.Show();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDivi_Click(object sender, EventArgs e)
        {
            try
            {
                value1 = double.Parse(txbValue1.Text);
                value2 = double.Parse(txbValue2.Text);
                if (value2 != 0)
                {
                    total = value1 / value2;
                    txbTotal.Text = total.ToString();
                    txbTotal.Show();
                }
                else
                {
                    MessageBox.Show("Impossible division by 0", "Error!!!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbValue1.Clear();
                    txbValue2.Clear();
                    txbTotal.Clear();
                    txbValue1.Focus();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbValue1.Clear();
            txbValue2.Clear();
            txbTotal.Clear();
            txbValue1.Focus();
            txbTotal.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente fechar ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {

            }
            else
            {
                Application.Exit();
            }
            
        }
    }
}
