using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrenteApostila.ConsoleApp.ModuloConta
{
    internal class ContaCorrente : Conta
    {
        public void Atualizar(double taxa)
        {
            this.saldo += this.saldo * taxa * 2;
        }
        public void Depositar(double valor)
        {
            this.saldo += valor - 0.10;
        }
    }
}
