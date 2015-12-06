using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegatez
{
    

    class Program
    {
        public delegate int removestr(int a, int b);
            static void Main(string[] args)
            {
                Console.WriteLine("Введите X: ");
                int x1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите Y: ");
                int y1 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Program instance = new Program();
                removestr method1 = new removestr(instance.meth);
                Console.WriteLine("result, x + y =  {0}\n", method1(x1, y1));
                removestr method2 = new removestr(instance.meth_2);

                Console.WriteLine("result, x - y =  {0}\n", method2(x1, y1));
                Console.ReadKey();
            }
            int meth(int a, int b)
            {

                return (a + b);
            }

            int meth_2(int x, int y)
            {
                return (x - y);
            }
    }
}
