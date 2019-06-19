using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp.CertMTA
{
    abstract class Distance
    {
        protected int feet;
        protected float inches;

        abstract public void setFeetAndInches(int feet, float inches);
        abstract public int getFeet();
        abstract public float getInches();
        abstract public string getDistanceComparison(Distance dist2);
    }

    //public interface IDistance : Distance
    //{

    //}

    //public class DistanceImplementation : Distance
    //{
    //    public DistanceImplementation()
    //    {
    //    }

    //    public override string getDistanceComparison(Distance dist2)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public override int getFeet()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public override float getInches()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public override void setFeetAndInches(int feet, float inches)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    class Rectangle
    {
        public static string ShapeName { get { return "Rectángulo"; } }
        public event EventHandler Changed;
        private double length;
        public double Length {get; set; }
        public double Width { get; set; }
//public double Length
//{

//    get
//    {

//        return length;

//    }
//    set
//    {

//        length = value;
//        Changed(this, EventArgs.Empty);

//    }
//}

public double GetArea() {

            return this.Length * this.Width;
        }

    }

    public class Program
    {
        

        // static string regularExpression = @"^(([a-z]{1,6})[_]?[0-9]{0,4}?)(@hackerrank.com$)";

        public static List<string> reformatDate(List<string> dates)
        {

            for (int i = 0; i < dates.Count(); i++)
            {
                string[] date = dates[i].Split(' ');

                if (!Enumerable.Range(1900, 2100).Contains(int.Parse(date[2])))
                {

                    dates[i] = "Year out of range Range(1900, 2100)";
                    continue;
                }
                
                date[0] = int.Parse(Regex.Match(date[0], @"\d+").Value).ToString("00");

                int month = DateTimeFormatInfo.CurrentInfo.AbbreviatedMonthNames.ToList().IndexOf(date[1]) + 1;

                dates[i] = date[2] + "-" + month.ToString("00") + "-" + date[0];
            }

            return dates;
        }

        public static string decode(List<string> codes, string encoded)
        {
            List<string> listCodes = new List<string>();
            Dictionary<string, string> codesDictionary = new Dictionary<string, string>();
            string result = string.Empty;
        
            int counterTakeElementSixToSix = 6;
            int lengthEncoded = encoded.Length / counterTakeElementSixToSix;

            listCodes = Enumerable.Range(0, encoded.Length / counterTakeElementSixToSix)
                    .Select(i => encoded.Substring(i * counterTakeElementSixToSix, counterTakeElementSixToSix)).ToList();

            for (int i = 0; i < codes.Count(); i++)
            {
                codesDictionary.Add(key: codes[i].Split(' ')[0], value: codes[i].Split(' ')[1]);
            }

            for (int i = 0; i < listCodes.Count(); i++)
            {
                result += !string.IsNullOrEmpty(codesDictionary.FirstOrDefault(x => x.Value == listCodes[i]).Key) ? codesDictionary.FirstOrDefault(x => x.Value == listCodes[i]).Key : "";
            }

            Console.Write(result);

            return result.Replace("[newline]", Environment.NewLine);
        }

        public static int maxShared(int friendsNodes, List<int> friendsFrom, List<int> friendsTo, List<int> friendsWeight)
        {
            int maximalValue = 0;
            Dictionary<int, string> groupfriendsNode = null;
            for (int i = 0; i < friendsWeight.Count; i++)
            {
                groupfriendsNode = new Dictionary<int, string>() {

                     { friendsWeight[i], friendsFrom[i].ToString()+" "+friendsTo[i].ToString() }
                };
            }

            maximalValue = (from t in groupfriendsNode
                           group t by t.Value into g
                           select new
                           {
                               maximal = g.Sum(x => x.Key)

                           }).Sum(x => x.maximal);


            return maximalValue;
        }
        //Pagina en la que me quede del libro la 34
        //Cambio en otra pc

        public struct Point {

            public double X, Y;

        }

        static void r_Changed(object sender, EventArgs e) {

            Rectangle r = (Rectangle)sender;
            Console.WriteLine(
                    "Value Changed : Length = {0}",
                    r.Length);

        }
        public static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.X = 10;
            p1.Y = 20;

            Point p2 = p1;
            p2.X = 100;

            Console.WriteLine("p1.X = {0}", p1.X);

            Rectangle rect1 = new Rectangle
            { Length = 10.0, Width = 20.0 };

            Rectangle rect2 = rect1;
            rect2.Length = 100.0;

            Console.WriteLine("rect1.Length = {0}", rect1.Length);

            //Rectangle rect = new Rectangle
            //{ Length = 10.0, Width = 20.0 };


            //Console.WriteLine("Nombre de la forma: {0}, Area: {1}", Rectangle.ShapeName, rect.GetArea());

            //Rectangle r = new Rectangle();
            //r.Changed += new EventHandler(r_Changed);
            //r.Length = 10;


            //List<int> friendsFrom = new List<int> { 1, 1,2,2,2 };
            //List<int> friendsTo = new List<int> { 2,2,3,3,4 };
            //List<int> friendsWeight = new List<int> { 1,2,1,3,3};
            //int friendsNodes = 4;

            //maxShared(friendsNodes, friendsFrom, friendsTo, friendsWeight);

            //List<string> characterCodes = new List<string>()
            //{
            //    "a 100100",
            //    "b 100101",
            //    "c 110001",
            //    "d 100000",
            //    "[newline] 111111",
            //    "p 111110",
            //    "q 000001"

            //};

            //string encoded = "111110000001100100111111100101110001111110";

            //decode(characterCodes, encoded);









            //List<string> hostnames = new List<string>();
            //List<string> hostnamesnewFile = new List<string>();
            //string filename = Console.ReadLine();
            //string outputfilename = string.Empty;
            //string outputResult = string.Empty;
            //StreamReader sr = new StreamReader(filename);
            //String line;
            //String AllLline;
            //int occurrencesHostName = 0;
            //try
            //{

            //    AllLline = sr.ReadToEnd();

            //    //close the file
            //    sr.Close();

            //    StreamReader sr2 = new StreamReader(filename);
            //    //Read the first line of text
            //    line = sr2.ReadLine();
            //    //Continue to read until you reach end of file
            //    while (line != null)
            //    {
            //        string[] splitLine = line.Split('-');

            //        if (!string.IsNullOrEmpty(splitLine[0]))
            //        {
            //            string hostname = splitLine[0].Trim();

            //            if (!hostnamesnewFile.Contains(hostname))
            //            {
            //                hostnamesnewFile.Add(hostname);
            //                occurrencesHostName = Regex.Matches(AllLline, splitLine[0].Trim()).Count;
            //                outputResult = "The host " + hostname + " made " + occurrencesHostName + " requests";
            //                hostnames.Add(outputResult);
            //                Console.WriteLine(outputResult);

            //            }

            //        }

            //        //Read the next line
            //        line = sr2.ReadLine();
            //    }

            //    //close the file
            //    sr2.Close();

            //    // WriteAllLines creates a file, writes a collection of strings to the file,
            //    outputfilename = "records_hosts_access_log_00.txt";
            //    System.IO.File.WriteAllLines(outputfilename, hostnames);

            //    Console.ReadLine();
            //}
            //catch(Exception e)
            //{
            //      Console.WriteLine("Exception: " + e.Message);
            //}
            // finally 
            //{
            //      Console.WriteLine("Executing finally block.");
            //}



            //List<string> dates = new List<string> { "1st Dec 1700", "2nd Feb 2013","4th Apr 1900"};

            //reformatDate(dates);

            //string regularExpression = @"^(([a-z]{1,6})[_]?[0-9]{0,4}?)(@hackerrank.com$)";

            //int query = Convert.ToInt32(Console.ReadLine());
            //var result = Enumerable.Repeat("False", query).ToArray();

            //for (int i = 0; i < query; i++)
            //{
            //    string someString = Console.ReadLine();

            //    if (Regex.IsMatch(someString, regularExpression))
            //    {
            //        result[i] = "True";
            //    }
            //}

            //foreach (var res in result)
            //{
            //    Console.WriteLine(res);
            //}


            //List<int> listBit = new List<int>();
            //List<int> listBitResult = new List<int>();


            //int number,i, length, tobase;

            //length = 8;
            //tobase = 2;
            //number = 161;

            //string theBinaryString = Convert.ToString(number, tobase).PadLeft(length, '0');

            //int[] binary = new int[length];

            //for (int y = 0; y < length; y++)
            //{
            //    binary[y] = int.Parse(theBinaryString[y].ToString());

            //    if (binary[y] == 1)
            //    {
            //        listBit.Add(y+1);
            //    }
            //}

            //listBitResult.Add(listBit.Count());

            //for (i = 0; i < listBit.Count(); i++)
            //{
            //    listBitResult.Add(listBit[i]);
            //    //Console.Write(listBit[i] + "\n\n");
            //}

            //for (i = 0; i < listBitResult.Count(); i++)
            //{
            //    Console.Write(listBitResult[i] + "\n\n");
            //}


            //    DateTime myDate1 = new DateTime(1970, 1, 9, 0, 0, 00);
            //    DateTime myDate2 = DateTime.Now;
            //    TimeSpan myDateResult;
            //    myDateResult = myDate2 - myDate1;
            //    Email email = new Email();

            // email.Calculate(myDateResult);

            //IEnumerable<int> oddNums =

            //    Enumerable.Range(20, 20).Where(x => x % 2 != 0);

            //oddNums.ToList()
            //List<int> arr = new List<int> { 1, 2, 5, 9, 6 };
            //int k = 5;
            //string result = findNumber(arr, k);
            //int index1 = Array.IndexOf(arr.ToArray(), k);
            //Console.WriteLine(index1);

            //int x = 0;
            //int y = 0;
            //int resultInt = 0;

            //x++; // Operadores unarios
            //++x;// Operadores unarios

            //resultInt = x + y; // Operadores binarios

            //string resultSTR = x > 0 ? "Si": "No" ; //TODO Operador Ternario, solo existe un solo operador ternario en C#

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
            //TryCatchFinallyTest();
            //int n = 20;
            //int d = n++ + 5;
            //Console.WriteLine("Rsultado de d = {0}",d);

            //int numberl = 10;
            //int number2 = 20;
            //if (number2 > numberl)
            //    Console.WriteLine("numberl");
            //Console.WriteLine("number2");

            //Rectangle r = new Rectangle();
            //r.Changed += new EventHandler(r_Changed);
            //r.Length = 10;
        }

        //static void r_Changed(object sender, EventArgs e)
        //{
        //    Rectangle r = (Rectangle)sender;
        //    Console.WriteLine(
        //     "Value Changed : Length = (0}", r.Length);
        //}

        public static string findNumber(List<int> arr, int k)
        {
            bool kExists = false;

            for (int i = 0; i < arr.Count(); i++)
            {
                if (arr[i] == k)
                {                   
                    kExists = true;
                    break;
                }
            }

            return kExists ? "YES" : "NO";

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
}
