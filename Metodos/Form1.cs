using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodos
{
    public partial class Mixto : Form
    {
        public Mixto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bttnGen_Click(object sender, EventArgs e)
        {
            int seed, a, c, mod, it, numrand, residuo;
            int val1, val2, val3, rule3, rule4;
            float division;

            seed = Convert.ToInt32(txtSeed.Text);
            a = Convert.ToInt32(txtA.Text);
            c = Convert.ToInt32(txtC.Text);
            mod = Convert.ToInt32(txtMod.Text);
            it = Convert.ToInt32(txtIt.Text);

            val1 = c;
            val2 = mod;
            val3 = mod;
            rule3 = val3 % 4;
            rule4 = (a - 1) % 4;
            while (val1 != 0 && val2 != 0)
            {
                if (val1 > val2)
                    val1 %= val2;
                else
                    val2 %= val1;
            }

            if (Math.Max(val1, val2) != 1)
            {
                randomNums.Text = "El valor de c y de mod son coprimos por lo tanto no se recomienda usar esos numeros.";

            } else if (rule3 != 0)
            {
                randomNums.Text = "El mod no es divisble por 4";

            }
            else if (rule4 != 0)
            {
                randomNums.Text = "La variable (a - 1) no es divisble por 4";

            }
            else

            {
                for (int i = 1; i <= it; i++)
                {
                    string newLine = Environment.NewLine;

                    numrand = seed * a + c;

                    residuo = numrand % mod;

                    division = (float)residuo / mod;

                    //residuo = seed;

                    seed = residuo;

                    //results.Text = results.Text + newLine + division.ToString();

                    randomNums.Text = randomNums.Text + newLine + division.ToString();


                }

            }
        

        }


        private void bttnClear_Click(object sender, EventArgs e)
        {

            //results.Text = "";
            randomNums.Text = "";
            
        }

        private void randomNums_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
