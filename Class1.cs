using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testando_solo
{
    internal class ContaPoupanca : Account
    {
        public override bool Saca(double valor)
        {
            if(this.Saldo > valor)
            {
                this.Saldo -= (valor + 0.1);
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
