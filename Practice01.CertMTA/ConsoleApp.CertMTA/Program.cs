using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.CertMTA
{
    public class Program
    {

        //Pagina en la que me quede del libro la 34
        //Cambio en otra pc
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
            //int number1 = 10;
            //int number2 = 20;

            //if (number2 > number1)
            //{
            //    Console.WriteLine("number2 es mayor que number1");
            //}

            //if (number1 > 5)
            //{
            //    Console.WriteLine("number1 es mayor que 5");

            //    if (number1 < 20)
            //    {
            //        Console.WriteLine("number1 es menor que 20");
            //    }
            //}

            //TestIfElse(10);
            //TestSwitch(10, 20, '+');
            //TestSwitchFallThrough();
            //WhileTest();
            //DoWhileTest();
            //ForTest();
            //ForInifinity();
            //ForEachTest();
            //int resulfactorial = Factorial(5);
            //Console.WriteLine(resulfactorial);
            //ExceptionTest();
            TryCatchFinallyTest();
            //int n = 20;
            //int d = n++ + 5;
            //Console.WriteLine("Rsultado de d = {0}",d);

            int numberl = 10;
            int number2 = 20;
            if (number2 > numberl)
                Console.WriteLine("numberl");
            Console.WriteLine("number2");
        }

        public static void TryCatchFinallyTest()
        {
            StreamReader sr = null;

            try
            {
                sr = File.OpenText(@"c:\data\data.txt");
                Console.WriteLine(sr.ReadToEnd());
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }    
        }

        public static void ExceptionTest()
        {
            /*
             *  Un bloque try debe
                tener, al menos,
                un bloque catch o
                un bloque finally
                asociado .
             */

            StreamReader sr = null;
            try
            {
                sr = File.OpenText(@"C:\data\data.txt");
                Console.WriteLine(sr.ReadToEnd());
            }

            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static int Factorial(int n)
        {
            /*
             * La recursión es una técnica de programación que hace que un método se llame a sí
               mismo para computar un resultado.*
             */
            if (n == 0)
            {
                n = 1; // Caso Base

                return n;
            }
            else
            {
                Console.WriteLine("El valor de n = {0}", n);
                return n * Factorial(n - 1); // Caso Recursivo
            }
        }

        public static void ForEachTest()
        {
            int[] numbers = { 1,2,3,4,5};

            foreach (int i in numbers)
            {
                Console.WriteLine("El valor de i = {0}", i);

            }
        }

        public static void ForInifinity() {

            for (; ;)
            {
                //No hace nada
            }
        }

        public static void ForTest()
        {
            /*
            for (init-expr; cond-expr; count- expr)
                sentencia 
            */
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("El valor de i = {0}",i);
            }
        }

        public static void DoWhileTest()
        {
            int i = 1;

            do
            {
                Console.WriteLine("El valor de i = {0}", i);
                i++;

            } while (i <= 5);
        }

        public static void WhileTest()
        {
            int i = 1;

            while (i <= 5)
            {
                Console.WriteLine("El valor de i = {0}", i);
                i++;
            }
        }

        public static void TestSwitch(int op1, int op2, char opr)
        {
            int result;

            switch (opr)
            {
                case '+':
                    result = op1 + op2;
                    break;
                case '-':
                    result = op1 - op2;
                    break;
                case '*':
                    result = op1 * op2;
                    break;
                case '/':
                    result = op1 / op2;
                    break;
                default:
                    Console.WriteLine("Operador Desconocido");
                    return;
            }

            Console.WriteLine("Resultado: {0}", result);

            return;
        }

        public static void TestSwitchFallThrough() {

            DateTime dt = DateTime.Today;

            switch (dt.DayOfWeek)
            { 
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday :
                Console.WriteLine("Hoy es un dia laboral");
                            break;
                            default:
                Console.WriteLine("Hoy es un dia de fin de semana");
                            break;
            }


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


    public class Rectangle
    {
        private double length;
        private double width;

        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }

        public double GetArea() {

            return length * width;
        }

    }
}
