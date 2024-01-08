using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calculadora_C_.interfaces
{
    public interface ICalculadora
    {
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);
        int Dividir(int num1, int num2)
        {
            return num1 / num2;
        } //quando o metodo da interface tem um corpo ele se torna um metodo opcional

    }
}