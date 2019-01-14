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



        private void decreaseByTenBtn_Click(object sender, EventArgs e)
        {
            layers = int.Parse(layersInputLabel.Text);

            if (layers < 11)
            {
                layers = 1;
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

            if (layers < 2)
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
                layers = 64;
                layersInputLabel.Text = layers.ToString();
            }
            else
            {
                layers = layers + 10;
                layersInputLabel.Text = layers.ToString();
            }
        }

        private void layersInputLabel_TextChanged(object sender, EventArgs e)
        {

            //For-Loop
            forLoopAnswer = 1;
            int powerInt = int.Parse(layersInputLabel.Text);

            try
            {
                for (int i = 0; i < powerInt; i++)
                {
                    forLoopAnswer *= 2;
                }
                forLoopAnswer--;


               

            }
            catch
            {

            }
            //machtsverheffing
            ulong layers = ulong.Parse(layersInputLabel.Text);

            mathPawAnswer = (ulong)Math.Pow(2, layers) - 1;


            //time
            ulong time = forLoopAnswer;
            ulong seconds;
            ulong minutes;
            ulong minutesModulo;
            ulong hours;
            ulong hoursModulo;
            ulong days;
            ulong daysModulo;
            ulong weeks;
            ulong weeksModulo;
            ulong years;
            ulong yearsModulo;
            ulong century;
            ulong centuryModulo;

            seconds = (time % 60); // seconds output
            minutesModulo = time / 60;
            minutes = (minutesModulo % 60); // minutes output
            hoursModulo = minutesModulo / 60;
            hours = (hoursModulo % 60);
            daysModulo = hoursModulo / 24;
            days = (daysModulo % 24);
            weeksModulo = daysModulo / 7;
            weeks = (weeksModulo % 7);
            yearsModulo = weeksModulo / 52;
            years = (yearsModulo % 52);
            centuryModulo = yearsModulo / 100;
            century = centuryModulo;


            outputForLoopLabel.Text = "Zetten: " + forLoopAnswer.ToString()
                + "\n\n Tijd:"
                + " \n Eewen: " + century.ToString()
                + " \n Jaren: " + years.ToString()
                + " \n Weken: " + weeks.ToString()
                + " \n Dagen: " + days.ToString()
                + " \n Uren: " + hours.ToString()
                + " \n Minuten: " + minutes.ToString()
                + " \n Secondens: " + seconds.ToString();

            outputMachtsverheffingLabel.Text = "Zetten: " + mathPawAnswer.ToString()
                    + "\n\n Tijd:"
                    + " \n Eewen: " + century
                    + " \n Jaren: " + years
                    + " \n Weken: " + weeks
                    + " \n Dagen: " + days
                    + " \n Uren: " + hours
                    + " \n Minuten: " + minutes
                    + " \n Secondens: " + seconds;
            
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
