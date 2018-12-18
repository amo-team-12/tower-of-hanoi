using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Torens_van_Hanoi
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private int a = 0;
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void grindTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void rulesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NYI!!!");
        }

        private void playsButton_Click(object sender, EventArgs e)
        {
            int powerInt = int.Parse(grindTextBox.Text);
            int numberInt = 2;
            int resultInt = 1;

            for (int i = 0; i < powerInt;i++)
            {
                resultInt *= numberInt;
            }

            resultInt--;

            resultLabel.Text = resultInt.ToString();

        }

        private void plusGrindButton_Click(object sender, EventArgs e)
        {
            a++;
            grindTextBox.Text = a.ToString();
        }

        private void minusGrindButton_Click(object sender, EventArgs e)
        {
            a--;
            grindTextBox.Text = a.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number;
            long result = 0;
            number = double.Parse(grindPowerTextBox.Text);


            result = (long)Math.Pow(2, number) - 1;


            powerLabel.Text = result.ToString();
        }

        private void plusPowerGrindButton_Click(object sender, EventArgs e)
        {
            a++;
            grindPowerTextBox.Text = a.ToString();
        }

        private void minusPowerGrindButton_Click(object sender, EventArgs e)
        {
            a--;
            grindPowerTextBox.Text = a.ToString();
        }
    }


}
