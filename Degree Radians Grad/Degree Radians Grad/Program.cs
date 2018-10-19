using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degree_Radians_Grad
{
    class Program
    {
        static void Main(string[] args)
        {
            double derece = 0, grad = 0, radyan = 0;
            Console.Write("Açıyı Giriniz = ");
            derece = Convert.ToDouble(Console.ReadLine());
            grad = (derece * 400) / 360;
            radyan = (derece * (2 * Math.PI)) / 360;
            Console.WriteLine("Grad cinsinden açınızın değeri = " + grad);
            Console.WriteLine("Radyan cinsinden açınızın değeri = " + radyan);


        }
    }
}
