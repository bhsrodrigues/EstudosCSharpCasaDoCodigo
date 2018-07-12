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

        private int position;

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            position = 0;

            RadioButton selectedRadioButtonCategoria = getSelectedRadioButton(grpboxCategoria);
            RadioButton selectedRadioButtonTurno = getSelectedRadioButton(grpboxTurno);

            if (selectedRadioButtonCategoria == null || selectedRadioButtonTurno == null)
            {
                MessageBox.Show("Por favor selecionar a categoria e o turno", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }


            dataGridConfig();

            getPayment(selectedRadioButtonCategoria, selectedRadioButtonTurno, 
                        Convert.ToInt16(txtSalarioMinimo.Text), Convert.ToInt16(txtHoras.Text));

            foreach (DataGridViewRow row in dtgdResult.Rows){
                row.Height = ((int)(row.Height * 0.8));
            }

        }

        private void dataGridConfig()
        {
            
            while (dtgdResult.Rows.Count != 0)
            {
                dtgdResult.Rows.Remove(dtgdResult.Rows[0]);
            }


            dtgdResult.ColumnHeadersVisible = false;
            if (dtgdResult.Columns.Count != 2)
            {
                dtgdResult.Columns.Add("Desc", "");
                dtgdResult.Columns.Add("Valor", "");
            }
            dtgdResult.Columns[0].Width = ((int)(dtgdResult.Width * 0.75));
            dtgdResult.ReadOnly = true;
            dtgdResult.Columns[1].Width = ((int)(dtgdResult.Width * 0.25));
            dtgdResult.RowHeadersVisible = false;
            dtgdResult.BorderStyle = BorderStyle.None;
            dtgdResult.AllowUserToResizeRows = false;
            dtgdResult.AllowUserToResizeColumns = false;
            dtgdResult.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dtgdResult.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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
            double finalSalary = salary + getGratification(rdoShift, Convert.ToInt32(txtHoras.Text)) +
                getFoodTickets(rdoCategory, Convert.ToDouble(txtSalarioMinimo.Text), salary) - getTax(rdoCategory, salary);
            addWorkerInformation("Valor do coeficiente:", coefficient);
            addWorkerInformation("Salário Bruto:", salary);
            addWorkerInformation("Valor do imposto:", getTax(rdoCategory, salary));
            addWorkerInformation("Valor da gratificação:", getGratification(rdoShift, Convert.ToInt32(txtHoras.Text)));
            addWorkerInformation("Valor do auxílio alimentação:", getFoodTickets(rdoCategory,
                                Convert.ToDouble(txtSalarioMinimo.Text),salary));
            addWorkerInformation("Salário líquido", finalSalary);
            dtgdResult.Rows[0].Selected = true;

            updateStatus(finalSalary);
        }

        public void addWorkerInformation(string label, double value)
        {
            //position = (284 / 3  - (label.Length - value.ToString().Length)) * -1;
            dtgdResult.Rows.Add();
            dtgdResult.Rows[position].Cells[0].Value = label;
            dtgdResult.Rows[position].Cells[1].Value = String.Format("{0:C}", value);
            position++;
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
            if (payment < 954)
            {
                txtStatus.Text = "Mal remunerado";
            }else if (payment < 954 * 1.75)
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            dtgdResult.Rows[e.RowIndex].Selected = true;
        }
    }
}
