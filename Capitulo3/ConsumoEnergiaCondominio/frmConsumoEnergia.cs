using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumoEnergiaCondominio
{
    public partial class FormConsumption : Form
    {

        private IList<Leitura> leituras = new BindingList<Leitura>();
        private BindingSource leituraSource = new BindingSource();

        public FormConsumption()
        {
            InitializeComponent();
            leituraSource.DataSource = leituras;
            dataGridView1.DataSource = leituraSource;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            insertConsumtpion(txtHouseNumber.Text, txtConsumption.Text);
        }

        private void insertConsumtpion(string house, string consumption)
        {
            Leitura leitura = new Leitura(house, consumption);

            if (leituras.Contains(leitura))
                MessageBox.Show("Casa já foi cadastada");
            else
                this.leituras.Add(leitura);
                clearForm();
        }

        private void clearForm()
        {
            txtConsumption.Clear();
            txtHouseNumber.Clear();
            txtHouseNumber.Focus();
        }



    }
}
