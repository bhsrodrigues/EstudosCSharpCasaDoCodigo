using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Idade
{
    public partial class frmMatricula : Form
    {
        public frmMatricula()
        {
            InitializeComponent();
        }

        public string getActualDate()
        {
            return dayStringFormat() + " de " + monthName() + " de " +
                DateTime.Now.Year.ToString();
        }

        public string dayStringFormat()
        {
            if (DateTime.Now.Day.ToString().Length == 1)
            {
                return "0" + DateTime.Now.Day.ToString();
            }
            return DateTime.Now.Day.ToString();
        }

        public string monthName()
        {
            string month = "";
            switch (DateTime.Now.Month)
            {
                case 1:
                    month = "janeiro";
                    break;
                case 2:
                    month = "fevereiro";
                    break;
                case 3:
                    month = "março";
                    break;
                case 4:
                    month = "abril";
                    break;
                case 5:
                    month = "maio";
                    break;
                case 6:
                    month = "junho";
                    break;
                case 7:
                    month = "julho";
                    break;
                case 8:
                    month = "agosto";
                    break;
                case 9:
                    month = "setembro";
                    break;
                case 10:
                    month = "outubro";
                    break;
                case 11:
                    month = "novembro";
                    break;
                case 12:
                    month = "dezembro";
                    break;
            }
            return month;
        }

        private void frmMatricula_Load(object sender, EventArgs e)
        {
            dtpNascimento.MaxDate = DateTime.Now;

            lblDataAtual.Text = getActualDate();
        }

        public bool validateDate(int lastBirthDate)
        {

            DateTime probablyDate = new DateTime(lastBirthDate, DateTime.Now.Month, DateTime.Now.Day);
            TimeSpan daysDifference = Convert.ToDateTime(probablyDate.ToShortDateString()) - Convert.ToDateTime(dtpNascimento.Value.ToShortDateString());

            if (DateTime.Now.Year %4 == 0)
            {
                return isLeapYear(daysDifference.TotalDays, 366);
            }
            else
            {
                return isLeapYear(daysDifference.TotalDays, 365);
            }

        }

        public bool isLeapYear(double totalDays, int daysYear)
        {
            if (totalDays >= daysYear)
            {
                return true;
            }
            return false;
        }

        private void txtUltimoAniversario_Leave(object sender, EventArgs e)
        {
            string mensagem = "Favor preencher o ano do último aniversário com \n\n";
            mensagem += "- Quatro dígitos;\n";
            mensagem += "- Último aniversário menor ao ano atual e maior em relação ao ano de nascimento.";
            if (txtUltimoAniversario.Text.Length < 4 ||
                Convert.ToInt16(txtUltimoAniversario.Text) > DateTime.Now.Year ||
                //Convert.ToInt16(txtUltimoAniversario.Text) == dtpNascimento.Value.Year ||
                Convert.ToInt16(txtUltimoAniversario.Text) < dtpNascimento.Value.Year ||
                !validateDate(Convert.ToInt16(txtUltimoAniversario.Text)))
            {
                MessageBox.Show(mensagem, "Data inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUltimoAniversario.Clear();
            }
        }
    }

    
}
