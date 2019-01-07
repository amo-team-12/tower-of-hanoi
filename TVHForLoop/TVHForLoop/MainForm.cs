using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVHForLoop
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }
        // fl is afkorting voor for-loop
        int fl = 0;

        // For-Loop

        private void indecreaseOneBtn_Click(object sender, EventArgs e)
        {
            forLoopInput = int.Parse(forLoopInputBox.Text);

            if (forLoopInput >= 64)
            {
                return;
            }
            else
            {
                fl++;
                forLoopInputBox.Text = fl.ToString();
            }
            
        }

        private void indecreaseTenBtn_Click(object sender, EventArgs e)
        {
            forLoopInput = int.Parse(forLoopInputBox.Text);

            if (forLoopInput >= 64)
            {
                return;
            }
            else if (forLoopInput >= 54)
            {
                forLoopInputBox.Text = "64";
                fl = 64;
            }
            else
            {
                fl = fl + 10;
                forLoopInputBox.Text = fl.ToString();
            }

        }

        private void decreaseOneBtn_Click(object sender, EventArgs e)
        {
            forLoopInput = int.Parse(forLoopInputBox.Text);

            if (forLoopInput < 1 )
            {
                return;
            }
            else
            {
                fl--;
                forLoopInputBox.Text = fl.ToString();
            }
        }

        private void decreaseTenBtn_Click(object sender, EventArgs e)
        {

            forLoopInput = int.Parse(forLoopInputBox.Text);

            if (forLoopInput < 10)
            {
                fl = 0;
                forLoopInputBox.Text = fl.ToString();
                return;
            } else
            {
                fl = fl - 10;
                forLoopInputBox.Text = fl.ToString();
            }
        }

        private void forLoopInputBox_TextChanged(object sender, EventArgs e)
        {
            ulong multyplayNumber = 2;
            ulong result = 1;
            int powerInt = int.Parse(forLoopInputBox.Text);

            try
            {
                for (int i = 0; i < powerInt; i++)
                {
                    result *= multyplayNumber;
                }
                result--;
                forLoopMovesOutputLabel.Text = "Aantal zetten: " + result.ToString();
            }
            catch
            {

            }

            //time sum
            int time = fl * 1;
            if (time > 0)
            {
                int seconds = time % 60;
                time -= seconds;
                time = time / 60;

                int minutes = time % 60;
                time -= minutes;
                time = time / 60;

                int hours = time % 24;
                time -= hours;
                time = time / 24;

                int days = time % 7;
                time -= days;
                time = time / 7;

                int weeks = time % 52;
                time -= weeks;
                time = time / 52;

                int years = time % 100;
                time -= years;
                time = time / 100;

                int century = time;
                time -= years;

                forLoopTimeOutputLabel.Text = century + "Eeuwen, "
                    + years + "j, "
                    + weeks + "w, "
                    + days + "d, "
                    + hours + "u, "
                    + minutes + "m, "
                    + seconds + "s, ";
            }

        }

        // Machtsverheffing

        // mf is een afkorting voor machtsverheffing 
        int machtsverheffing = 0;
        int forLoopInput;
        int mInput;

        private void mIncreaseOneBtn_Click(object sender, EventArgs e)
        {
            mInput = int.Parse(mInputBox.Text);

            if (mInput >= 64)
            {
                return;
            }
            else
            {
                machtsverheffing++;
                mInputBox.Text = machtsverheffing.ToString();
            }

        }

        private void mIncreaseTenBtn_Click(object sender, EventArgs e)
        {
            mInput = int.Parse(mInputBox.Text);

            if (mInput >= 64)
            {
                return;
            }
            else if (mInput >= 54)
            {
                mInputBox.Text = "64";
                machtsverheffing = 64;
            }
            else
            {
                machtsverheffing = machtsverheffing + 10;
                mInputBox.Text = machtsverheffing.ToString();
            }
        }

        private void mdecreaseOneBtn_Click(object sender, EventArgs e)
        {
            mInput = int.Parse(mInputBox.Text);

            if (mInput < 1)
            {
                return;
            }
            else
            {
                machtsverheffing--;
                mInputBox.Text = machtsverheffing.ToString();
            }
        }

        private void mDecreaseTenBtn_Click(object sender, EventArgs e)
        {
            mInput = int.Parse(mInputBox.Text);

            if (mInput <= 10)
            {
                machtsverheffing = 0;
                mInputBox.Text = machtsverheffing.ToString();
                return;
            }
            else
            {
                machtsverheffing = machtsverheffing - 10;
                mInputBox.Text = machtsverheffing.ToString();
            }
        }

        private void mInputBox_TextChanged(object sender, EventArgs e)
        {
            ulong layers = ulong.Parse(mInputBox.Text);

            ulong sum = (ulong)Math.Pow(2, layers) - 1;

            mMovesOutputLabel.Text = "Aantal zetten: " + sum.ToString();
        }
    }
}
