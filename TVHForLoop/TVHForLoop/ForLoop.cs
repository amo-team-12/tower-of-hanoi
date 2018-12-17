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
        public ForLoop()
        {
            InitializeComponent();
        }

        // Formule = 2^(layers) - 1 = math.pow()
        
        private void layerInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // verandert de tekst naar een rekenbare int
                int layers = int.Parse(layerInput.Text);

                for (int i = 0; i < 10; i++)
                {

                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("error");
            }
        }
    }
}
