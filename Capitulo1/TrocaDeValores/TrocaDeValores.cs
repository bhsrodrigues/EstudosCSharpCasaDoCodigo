using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrocaDeValores
{
    public partial class TrocaDeValores : Form
    {
        public TrocaDeValores()
        {
            InitializeComponent();
        }

        private void btnTrocar_Click(object sender, EventArgs e)
        {
            String value = txtValue1.Text;
            txtValue1.Text = txtValue2.Text;
            txtValue2.Text = value;
        }
    }
}
