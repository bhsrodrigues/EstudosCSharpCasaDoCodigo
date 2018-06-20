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

            getPayment(selectedRadioButtonCategoria, selectedRadioButtonTurno, 700, 100);
            updateStatus(0);
        }

        public double getFoodTickets(RadioButton rdoCategory, double minimunPayment, double payment)
        {
            //double foodTicket = 0;
            if (rdoCategory.Text.Trim().Equals("Calouro") && payment < minimunPayment / 2)
            {
                return payment / 3;
            }else
            {
                return payment / 6;
            }
        }

        public void getPayment(RadioButton rdoCategory, RadioButton rdoShift, 
            double minimumPayment, int hours)
        {
            double payment = hours * getCoefficient(rdoShift, hours);
            double tax = 0;
            switch (rdoCategory.Text.Trim())
            {
                case "Calouro":
                    if (payment < 300)
                    {
                        tax = payment * 0.01;
                    }
                    else
                    {
                        tax = payment * 0.02;
                    }
                    break;
                case "Veterano":
                    if (payment < 400)
                    {
                        tax = payment * 0.03;
                    }
                    else
                    {
                        tax = payment * 0.04;
                    }
                    break;
            
            }
            updateSalary(getCoefficient(rdoShift, hours));
        }

        public void updateSalary(double coefficient)
        {
            lstboxResult.Items.Add("Valor do coeficiente......" + coefficient.ToString());
        }

        private double getCoefficient(RadioButton rdoShift, double minumunPayment)
        {

            double coefficient = 0;

            switch (rdoShift.Text.Replace("&",""))
            {
                case "Matutino":
                    coefficient = minumunPayment * 0.01;
                    break;
                case "Vespertino":
                    coefficient = minumunPayment * 0.02;
                    break;
                case "Noturno":
                    coefficient = minumunPayment * 0.03;
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
