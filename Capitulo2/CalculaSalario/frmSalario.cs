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

        private int position = 0;

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

        private double calculateTax(double payment, double percentual)
        {
            return payment * percentual;
        }

        public double getTax(RadioButton rdoCategory, double payment)
        {
            double tax = 0;

            switch (rdoCategory.Text.Replace("&",""))
            {
                case "Calouro":
                    if (payment < 300)
                    {
                        tax = calculateTax(payment, 0.01);
                        break;
                    }
                    else
                    {
                        tax = calculateTax(payment, 0.02);
                        break;
                    }
                case "Veterano":
                    if (payment < 300)
                    {
                        tax = calculateTax(payment, 0.03);
                        break;
                    }
                    else
                    {
                        tax = calculateTax(payment, 0.04);
                        break;
                    }
                
            }
            return tax;
            
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
            updateSalary(getCoefficient(rdoShift, minimumPayment), rdoCategory, rdoShift);
        }

        public void updateSalary(double coefficient, RadioButton rdoCategory, RadioButton rdoShift)
        {
            double salary = coefficient * Convert.ToInt16(txtHoras.Text);
            addWorkerInformation("Valor do coeficiente", coefficient);
            lstboxResult.Items.Add(String.Format("{0,-68}{1:C}",
                                    "Valor do coeficiente",coefficient));
            MessageBox.Show(lstboxResult.Items[0].ToString().Length.ToString());
            addWorkerInformation("Salário Bruto", salary);
            lstboxResult.Items.Add(String.Format("{0,-69}{1:C}",
                                    "Salário bruto", salary));
            MessageBox.Show(lstboxResult.Items[3].ToString().Length.ToString());
            lstboxResult.Items.Add(String.Format("{0,-68}{1:C}",
                                    "Valor do imposto", getTax(rdoCategory,salary)));
            
            lstboxResult.Items.Add(String.Format("{0, -68}{1:C}",
                                    "Valor da gratificação", getGratification(rdoShift, Convert.ToInt32(txtHoras.Text))));
        }

        public void addWorkerInformation(string label, double value)
        {
            position = (284 / 3  - (label.Length - value.ToString().Length)) * -1;
            Console.WriteLine(lstboxResult.Size.Width.ToString());
            lstboxResult.Items.Add(String.Format("{0," + position.ToString() + "}{1:C}", label, value));
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
