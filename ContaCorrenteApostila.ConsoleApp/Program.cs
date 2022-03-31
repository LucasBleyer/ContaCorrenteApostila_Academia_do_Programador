using System;

namespace ContaCorrenteApostila.ConsoleApp.ModuloConta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();
            ContaCorrente cc = new ContaCorrente();
            ContaPoupanca cp = new ContaPoupanca();

            c.Depositar(1000);
            cc.Depositar(1000);
            cp.Depositar(1000);

            c.Atualizar(0.01);
            cc.Atualizar(0.01);
            cp.Atualizar(0.01);

            Console.WriteLine("Saldo Conta: " + Math.Round(c.Saldo, 2));
            Console.WriteLine("Saldo Conta Corrente: " + Math.Round(cc.Saldo, 2));
            Console.WriteLine("Saldo Conta Poupança: " + Math.Round(cp.Saldo, 2));
        }
    }
}