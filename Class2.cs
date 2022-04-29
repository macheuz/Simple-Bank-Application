using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testando_solo
{
    internal class TotalizadorDeContas
    {
        public double ValorTotal { get; private set; }
        public void Soma(Account conta)
        {
            ValorTotal += conta.Saldo;
        }
    }
}
