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

            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddFirst(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.AddLast(5);

            linkedList.AddBefore(linkedList.Find(2), 6);

            Console.WriteLine("Listas Enlazadas***************************************************");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }

            linkedList.Remove(2);

            Console.WriteLine("Listas Enlazadas Removed***************************************************");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
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

            //BubbleSort algorithm
            int[] numbers = new int[] { 20, 30, 10, 40,5 };
            // Console.WriteLine("Desordenados***************************************************");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //numbers =  BubbleSort(numbers);

            //Console.WriteLine("Ordenados***************************************************");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            numbers = QuickSort(numbers,0, numbers.Length - 1);

            Console.WriteLine("QuickSort***************************************************");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            int[,] array = new int[4,5]; //mxn donde m = fila y n = columna
            array[0, 0] = 10;
            array[0, 1] = 20;
            array[0, 2] = 5;
            array[0, 3] = 8;
            array[0, 4] = 4;

            array[1, 0] = 2;
            array[1, 1] = 15;
            array[1, 2] = 25;
            array[1, 3] = 22;
            array[1, 4] = 23;

            array[2, 0] = 30;
            array[2, 1] = 2011;
            array[2, 2] = 150;
            array[2, 3] = 210;
            array[2, 4] = 65;

            array[3, 0] = 60;
            array[3, 1] = 51;
            array[3, 2] = 300;
            array[3, 3] = 95;
            array[3, 4] = 103;

            int[] result = GetMaxRowElement(array);

            for (int i = 0; i <= result.Count(); i++)
            {
                Console.WriteLine($"Fila: {i+1} elemento de mayor valor: {result[i]} \n");


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

        public static int[] BubbleSort(int[] numbers) {


            bool swapped;

            do
            {
                swapped = false;
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        //swap
                        int temp = numbers[i + 1];
                        numbers[i + 1] = numbers[i];
                        numbers[i] = temp;
                        swapped = true;
                    }
                }
            } while (swapped == true);


            return numbers;
        }

        public static int Partition(int[] numbers, int left, int right, int pivotIndex)
        {
            int pivotValue = numbers[pivotIndex];

            //Se mueve el elemento pivote al final
            int temp = numbers[right];
            numbers[right] = numbers[pivotIndex];
            numbers[pivotIndex] = temp;

            //newPivot almacena el indice del primer numero
            //mayor que el pivote
            int newPivot = left;
            for (int i = left; i < right; i++)
            {
                if (numbers[i] <= pivotValue)
                {
                    //Intercambiamos
                    temp = numbers[newPivot];
                    numbers[newPivot] = numbers[i];
                    numbers[i] = temp;
                    newPivot++;
                }
            }

            //Mueve el elemento pivote a su posicion // almacenada
            temp = numbers[right];
            numbers[right] = numbers[newPivot];
            numbers[newPivot] = temp;


            return newPivot;
        }

        public static int[] GetMaxRowElement(int[,] array)
        {
            int[] maxElementPerRow = new int[array.GetLength(0)];

            for (int i = 0; i <= array.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < array.GetLength(1) - 1; j++)
                {
                    if (array[i,j] > array[i, j+1])
                    {
                        //Swap
                        int temp = array[i, j + 1];
                        array[i, j + 1] = array[i, j];
                        array[i, j] = temp;
                    }
                }
            }

            int arraylasIndex = array.GetLength(1) - 1;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                int t = array[i, arraylasIndex];

                maxElementPerRow[i] = array[i, arraylasIndex];               

            }


            return maxElementPerRow;

        }

        public static int[] QuickSort(int[] numbers, int left, int right)
        {
            //Caso base de la recursion
            if (right > left)
            {
                int pivotIndex = left + (right - left) / 2;

                //Particiona el vector
                pivotIndex = Partition(numbers, left, right, pivotIndex);
              
                //Ordena la particion izquierda
                QuickSort(numbers, left, pivotIndex - 1);
                
                //Ordena la parte derecha
                QuickSort(numbers, pivotIndex + 1, right);
            }

            return numbers;
        }

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
