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
    public partial class ForLoop : Form
    {

        public int powerInt;

        public ForLoop()
        {
            InitializeComponent();
        }

        private void layerInputBox_TextChanged(object sender, EventArgs e)
        {
            int catcher = 0;
            int numberInt = 2;
            int resultInt = 1;
            try
            {
                powerInt = int.Parse(layerInputBox.Text);
            }
            catch
            {

            }
            try
            {
                for (int i = 0; i < powerInt; i++)
                {
                    resultInt *= numberInt;
                }
                resultInt--;

                movesOutputLabel.Text = "Zetten: " + resultInt.ToString();
            }
            catch
            {

            }
        }
    }
}
