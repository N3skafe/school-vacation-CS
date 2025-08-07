using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial02
{
    internal class Gugudan
    {
        //static void Main()
        public void Gugudan_print1()
        {
            for (int i = 2; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine("{0} * {1} = {2}", i, j, i * j);
                }
            }
        }
        public void Gugudan_print2()
        {
            Console.WriteLine("start number");
            int start = Int32.Parse(Console.ReadLine());
            Console.WriteLine("last number");
            int last = Int32.Parse(Console.ReadLine());
            for (int i = start; i <= last; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine("{0} * {1} = {2}", i, j, i *j);
                }
            }

        }
    }
}
