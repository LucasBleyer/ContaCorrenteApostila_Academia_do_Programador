using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrenteApostila.ConsoleApp.ModuloConta
{
    internal class Conta
    {
        private double saldo;

        public double Saldo
        {
            get { return saldo; }
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

    }
}
