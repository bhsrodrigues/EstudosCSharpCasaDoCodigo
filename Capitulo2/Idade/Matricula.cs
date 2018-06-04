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
    }

    
}
