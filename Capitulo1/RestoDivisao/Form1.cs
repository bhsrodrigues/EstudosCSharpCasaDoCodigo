using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoDivisao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtDividendo.Text == "" || txtDivisor.Text == "")
            {
                MessageBox.Show("Favor preencher os dois campos", "Erro", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }else
            {
                if (Convert.ToInt16(txtDivisor.Text) == 0)
                {
                    MessageBox.Show("Nenhum número pode ser dividido por 0""Erro", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                else
                {
                    txtResto.Text = (Convert.ToInt16(txtDividendo.Text) % Convert.ToInt16(txtDivisor.Text)).ToString();
                }
            }
        }
    }
}
