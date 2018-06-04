using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GastoRestaurante
{
    public partial class frmGastoRestaurante : Form
    {
        public frmGastoRestaurante()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtResultadoPercentual.Text = (Convert.ToDouble(txtValorDespesa.Text) * 1.1).ToString();
        }
    }
}
