using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testando_solo
{
    internal class Conta
    {
        private string titular;
        private int contanumero;
        private double saldo;

        public int ContaNumero
        {
            get { return contanumero; }
            set { contanumero = value; }
        }
        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public virtual bool Saca(double valor)
        {
            if (this.saldo > valor)
            {
                this.saldo -= valor;
                return true;
            }
            return false;
        }
        public void Deposita(double valor)
        {
            this.saldo += valor;
        }
    }
    
}
