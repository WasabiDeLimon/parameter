using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecuaciones_Paramétricas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ecuaciones Paramétricas";
            Console.WriteLine("Valores en x");
            for (int t = -1; t<=5; t++)
            {
                double res = t - 7;
                Console.WriteLine("x en {0} = {1} ", t, res);
            }
            Console.WriteLine("\nValores en y");
            for (int t= -1; t<=5; t++)
            {
                double res = (t * 2) - 7;
                Console.WriteLine("y en {0} = {1} ", t, res);
            }
            
            Console.ReadKey();
        }
    }
}
