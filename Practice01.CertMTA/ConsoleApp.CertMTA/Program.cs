using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.CertMTA
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int resultInt = 0;

            x++; // Operadores unarios
            ++x;// Operadores unarios

            resultInt = x + y; // Operadores binarios

            string resultSTR = x > 0 ? "Si": "No" ; //TODO Operador Ternario, solo existe un solo operador ternario en C#
        }
    }
}
