using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Interface
{
    public interface IConta
    {
            
        public double saldo { get; set; }
        public int numero { get; set; }
        Cliente cliente { get; set; }


        double CalcularSaldo();

        void Sacar(double valor);

        void Depositar(double valor);

    }
    
}
