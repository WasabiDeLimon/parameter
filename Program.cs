using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parametric_Ecuations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Parametric Ecuations";
            Console.WriteLine("Values on x");
            for (int t = -1; t<=5; t++)
            {
                double res = t - 7;
                Console.WriteLine("x in {0} = {1} ", t, res);
            }
            Console.WriteLine("\nValues on y");
            for (int t= -1; t<=5; t++)
            {
                double res = (t * 2) - 7;
                Console.WriteLine("y in {0} = {1} ", t, res);
            }
            
            Console.ReadKey();
        }
    }
}
