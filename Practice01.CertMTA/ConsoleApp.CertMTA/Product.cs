using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.CertMTA
{
    public class Product
    {
        public string Name {

            get {

                return Name;
            }

            set {

                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    Name = value;
                }
            }

        }

        public double Price { get; set; }

        public void ToString()
        {
            Console.WriteLine("El nombre del produco es {0} y su precio es {1}", Name, Price);
        }
    }

    //93
    public struct Point
    {
        public double X, Y, Z;
    }
}
