using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.CertMTA
{
    public class Program
    {

        //Pagina en la que me quede del libro la 34
        public static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int resultInt = 0;

            x++; // Operadores unarios
            ++x;// Operadores unarios

            resultInt = x + y; // Operadores binarios

            string resultSTR = x > 0 ? "Si": "No" ; //TODO Operador Ternario, solo existe un solo operador ternario en C#

            //Estructuras de decision en C# son: if, if-else y switch
            int number1 = 10;
            int number2 = 20;

            if (number2 > number1)
            {
                Console.WriteLine("number2 es mayor que number1");
            }

            if (number1 > 5)
            {
                Console.WriteLine("number1 es mayor que 5");

                if (number1 < 20)
                {
                    Console.WriteLine("number1 es menor que 20");
                }
            }

            TestIfElse(10);
        }

        public static void TestIfElse(int n)
        {
            if (n < 10)
            {
                Console.WriteLine("n es menor que 10");
            }
            else if (n < 30)
            {
                Console.WriteLine("n es menor que 30");
            }
            else
            {
                Console.WriteLine("n es mayor que o igual que 30");
            }
        }
    }
}
