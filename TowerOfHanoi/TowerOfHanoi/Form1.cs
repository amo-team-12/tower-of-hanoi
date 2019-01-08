using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TowerOfHanoi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //variables
        int layers = 0;
        ulong forLoopAnswer;
        ulong mathPawAnswer;
        ulong century;
        ulong years;
        ulong weeks;
        ulong days;
        ulong hours;
        ulong minutes;
        ulong seconds;


        private void decreaseByTenBtn_Click(object sender, EventArgs e)
        {
            layers = int.Parse(layersInputLabel.Text);

            if (layers < 10)
            {
                layers = 0;
                layersInputLabel.Text = layers.ToString();
                return;
            }
            else
            {
                layers = layers - 10;
                layersInputLabel.Text = layers.ToString();
            }
        }

        private void decreaseByOneBtn_Click(object sender, EventArgs e)
        {
            layers = int.Parse(layersInputLabel.Text);

            if (layers < 1)
            {
                return;
            }
            else
            {
                layers--;
                layersInputLabel.Text = layers.ToString();
            }
        }

        private void increaseByOneBtn_Click(object sender, EventArgs e)
        {
            layers = int.Parse(layersInputLabel.Text);

            if (layers >= 64)
            {
                return;
            }
            else
            {
                layers++;
                layersInputLabel.Text = layers.ToString();
            }
        }

        private void increaseByTenBtn_Click(object sender, EventArgs e)
        {
            layers = int.Parse(layersInputLabel.Text);

            if (layers >= 64)
            {
                return;
            }
            else if (layers >= 54)
            {
                layersInputLabel.Text = "64";
                layers = 64;
            }
            else
            {
                layers = layers + 10;
                layersInputLabel.Text = layers.ToString();
            }
        }

        private void layersInputLabel_TextChanged(object sender, EventArgs e)
        {
            //time:
            ulong time = forLoopAnswer * 1;
            if (time > 0)
            {
                seconds = time % 60;
                time -= seconds;
                time = time / 60;

                minutes = time % 60;
                time -= minutes;
                time = time / 60;

                hours = time % 24;
                time -= hours;
                time = time / 24;

                days = time % 7;
                time -= days;
                time = time / 7;

                weeks = time % 52;
                time -= weeks;
                time = time / 52;

                years = time % 100;
                time -= years;
                time = time / 100;

                century = time;
                time -= years;
            }



            //For-Loop
            ulong multyplayNumber = 2;
            forLoopAnswer = 1;
            int powerInt = int.Parse(layersInputLabel.Text);

            try
            {
                for (int i = 0; i < powerInt; i++)
                {
                    forLoopAnswer *= multyplayNumber;
                }
                forLoopAnswer--;
                outputForLoopLabel.Text = "Zetten: " + forLoopAnswer.ToString() 
                    + "\n\n Tijd:"
                    + " \n Eewen: "+ century
                    + " \n Jaren: " + years
                    + " \n Weken: " + weeks
                    + " \n Dagen: " + days
                    + " \n Uren: " + hours
                    + " \n Minuten: " + minutes 
                    + " \n Secondens: " + seconds;
            }
            catch
            {

            }
            //machtsverheffing
            ulong layers = ulong.Parse(layersInputLabel.Text);

            mathPawAnswer = (ulong)Math.Pow(2, layers) - 1;

            outputMachtsverheffingLabel.Text = "Zetten: " + mathPawAnswer.ToString()
                    + "\n\n Tijd:"
                    + " \n Eewen: " + century
                    + " \n Jaren: " + years
                    + " \n Weken: " + weeks
                    + " \n Dagen: " + days
                    + " \n Uren: " + hours
                    + " \n Minuten: " + minutes
                    + " \n Secondens: " + seconds;

            //recusrie output: 
            outputRecursieLabel.Text = "Zetten: " + calculate(int.Parse(layersInputLabel.Text), 0, 0).ToString()
                    + "\n\n Tijd:"
                    + " \n Eewen: " + century
                    + " \n Jaren: " + years
                    + " \n Weken: " + weeks
                    + " \n Dagen: " + days
                    + " \n Uren: " + hours
                    + " \n Minuten: " + minutes
                    + " \n Secondens: " + seconds;
        }

        //recursie
        private ulong calculate(int disks, int counter, ulong steps)
        {
            if (counter >= layers)
            {
                return steps;
            }
            steps = steps * 2 + 1;
            counter++;
            return calculate(disks, counter, steps);
        }

    }
}
