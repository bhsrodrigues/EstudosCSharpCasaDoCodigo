using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculaSalario
{
    public partial class frmSalario : Form
    {
        public frmSalario()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            RadioButton selectedRadioButtonCategoria = getSelectedRadioButton(grpboxCategoria);
            RadioButton selectedRadioButtonTurno = getSelectedRadioButton(grpboxTurno);

            if (selectedRadioButtonCategoria == null || selectedRadioButtonTurno == null)
            {
                MessageBox.Show("Por favor selecionar a categoria e o turno", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }

            updateStatus(0);
        }

        private double getCoefficient(RadioButton rdoShift, double payment)
        {

            double coefficient = 0;

            switch (rdoShift.Text.Replace("&",""))
            {
                case "Matutino":
                    coefficient = payment * 0.01;
                    break;
                case "Vespertino":
                    coefficient = payment * 0.02;
                    break;
                case "Noturno":
                    coefficient = payment * 0.03;
                    break;
            }

            return coefficient;
        }

        private double getGratification(RadioButton rdoShift, int workHours)
        {

            switch (rdoShift.Text.Replace("&", ""))
            {
                case "Noturno":
                    if (workHours > 8)
                    {
                        return 50;
                    }
                    else
                    {
                        return 30;
                    }
            }
            return 30;
        }

        private RadioButton getSelectedRadioButton(GroupBox group)
        {
            return group.Controls.OfType<RadioButton>().SingleOrDefault(r => r.Checked);
        }

        public void updateStatus(double payment)
        {
            if (payment < 350)
            {
                txtStatus.Text = "Mal remunerado";
            }else if (payment < 600)
            {
                txtStatus.Text = "Normal";
            }else
            {
                txtStatus.Text = "Bem remunerado";
            }

            txtStatus.Font = new Font(this.Font, FontStyle.Bold);
            txtStatus.BackColor = Color.Yellow;
            txtStatus.ForeColor = Color.Blue;
            txtStatus.TextAlign = HorizontalAlignment.Center;
        }
    }
}
