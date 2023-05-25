using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Interface
{
    public class Corrente : IConta
    {
        public double saldo { get; set; }
        public int numero { get; set; }
        public Cliente cliente { get; set; }


        public double CalcularSaldo()
        {
            return saldo;
        }

        public void Depositar(double valor)
        {
            saldo += valor;

        }

        public void Sacar(double valor)
        {
            if (valor > saldo)
            {
                Console.WriteLine("Saldo insuficiente.");
            }
            else
            {
                saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso.");
            }

        }
    }
}
