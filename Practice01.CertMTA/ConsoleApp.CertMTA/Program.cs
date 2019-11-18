using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static ConsoleApp.CertMTA.Program;

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


    //abstract class Polygon
    //{

    //    public double Length { get; protected set; }
    //    public double Width { get; protected set; }

    //    abstract public double GetArea();
    //}

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
            //Console.WriteLine(
            //        "Value Changed : Length = {0}",
            //        r.Length);

        }


        public static void Main(string[] args)
        {



            //Triangle t = new Triangle();
            //t.Draw();

            //Polygon po = t;
            //po.Draw();


            //Rectangle rect1 = new Rectangle { Length = 10, Width = 20 };
            //Rectangle rect2 = new Rectangle { Length = 100, Width = 200 };

            //Console.WriteLine(rect2.CompareTo(rect1));

            //Product p = new Product { Name = "Plancha"};

            //Console.WriteLine(p.Name);

            string word = string.Empty;

            Queue queue = new Queue();
            queue.Enqueue("Hola");
            queue.Enqueue(1);
            queue.Enqueue(DateTime.Now);


            Stack stack = new Stack();
            stack.Push("Esto es una Pila (Stack)");
            stack.Push(DateTime.Now);
            stack.Push(20.59);

            Console.WriteLine("Cola***************************************************");
            for (byte i = 0; i < 3; i++)
            {

                word = queue.Dequeue().ToString();

               
                Console.WriteLine(word);

            }

            Console.WriteLine("Pila***************************************************");
            for (byte i = 0; i < 3; i++)
            {
               
                word = stack.Pop().ToString();

                Console.WriteLine(word);

            }


        }

        RectangleHandler handler;

            //handler += new RectangleHandler(DisplayArea);
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
            TryCatchFinallyTest();

            //Polygon p = new Rectangle(10, 20);


            //object o = new Rectangle(10, 20);

            //if (o is Rectangle)
            //{

            //    Rectangle r = (Rectangle)o;
            //}

            //Rectangle r2 = o as Rectangle;

            //if (r2 != null)
            //{
            //    // Do Something
            //}


            //List<Polygon> polygons = new List<Polygon>();
            //polygons.Add(new Polygon());
            //polygons.Add(new Rectangle(10,20));
            //polygons.Add(new Triangle());

            //foreach (Polygon po in polygons)
            //{
            //    po.Draw();
            //}


            return "";

        }

        public delegate void RectangleHandler(Rectangle rect);

        public static void DisplayArea(Rectangle rect) {
            //return kExists ? "YES" : "NO";

            //Console.WriteLine(rect.GetArea());
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


    public class Triangle : Polygon
    {
        

        public new void Draw()
        {
            Console.WriteLine("Dibijando: Triangulo");
        }

        //public override double GetArea()
        //{
        //    throw new NotImplementedException();
        //}
    }

    public class Rectangle : Polygon, IComparable
    {
        public double Length { get; set; }
        public double Width { get; set; }


        //public Rectangle(double length, double width)
        //{
        //    Length = length;
        //    Width = width;
        //}

        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;

            if (!(obj is Rectangle))
                throw new ArgumentException();

            Rectangle target = (Rectangle)obj;
            double diff = this.GetArea() - target.GetArea();

            if (diff == 0)
                return 0;
            else if (diff > 0)
                return 1;
            else return -1;
        }

        public override void Draw()
        {
            Console.WriteLine("Dibijando: Rectangulo");
        }

        
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public double GetArea()
        {
            return Width * Length;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return String.Format("Width = {0}, Length = {1}", this.Width, this.Length);
        }

    }

    public sealed class RectangleSealed : Polygon
    {

        // Miembros de la clase aqui
        //sealed public override double GetArea()
        //{
        //    return Width * Length;
        //}
        //public override double GetArea()
        //{
        //    throw new NotImplementedException();
        //}
    }

    public class Polygon : Object
    {

        public double Length { get; set; }
        public double Width { get; set; }

        public virtual void Draw() {

            Console.WriteLine("Dibijando: Poligono");

        }
    }

}
