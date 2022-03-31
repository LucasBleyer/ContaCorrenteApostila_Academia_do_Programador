using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrenteApostila.ConsoleApp.ModuloConta
{
    internal class ContaPoupanca : Conta
    {
        public void Atualizar(double taxa)
        {
           this.saldo += this.saldo * taxa * 3;
        }
    }
}