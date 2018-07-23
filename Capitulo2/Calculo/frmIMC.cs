using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo
{
    public partial class frmIMC : Form
    {
        public frmIMC()
        {
            InitializeComponent();
        }

        
        public void calculateIMC()
        {
            double heigth = 0, imc;
            try
            {
                String teste = txtHeight.Text.Replace(".","").Replace(",","");
                teste = teste.Substring(0, teste.Length - 2) + "," + teste.Substring(teste.Length - 2);
                heigth = Convert.ToDouble(teste);
            }
            catch(Exception ex)
            {
                new CancelEventArgs().Cancel = true;
            }

            if (rdbFemale.Checked)
            {
                imc = (62.1 * heigth) - 44.7;
            }
            else
            {
                imc = (72.7 * heigth) - 58;
            }
            lblIMC.Text = String.Format("{0:n2}", imc);
            lblIMC.ForeColor = Color.Red;

            lblIMC.Visible = true;
        }

        private void rdbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (txtHeight.Text.Length !=0)
            {
                calculateIMC();
            }
        }

        private void txtHeight_Leave(object sender, EventArgs e)
        {
            calculateIMC();
        }

        private void frmIMC_Load(object sender, EventArgs e)
        {

        }
    }
}
