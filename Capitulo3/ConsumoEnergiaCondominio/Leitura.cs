using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoEnergiaCondominio
{
    class Leitura
    {
        
        public string Casa { protected set; get; }
        public double Consumo { protected set; get; }
        public double Desconto
        {
            get
            {
                return Consumo * 0.2;
            }
        }

        public Leitura (string house, string consumption)
        {
            this.Casa = house;
            this.Consumo = Convert.ToInt16(consumption);
        }

        public override bool Equals(Object obj)
        {
            //Leitura l = obj as Leitura;
            Leitura l = (Leitura)obj;
            if (l == null)
                return false;
            else
                return l.Casa.Equals(this.Casa);
        }

        public override int GetHashCode()
        {
            return new { this.Casa,this.Consumo}.GetHashCode();
        }
    }
}
