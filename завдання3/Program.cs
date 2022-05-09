using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace завдання3
{
    internal class Program
    {
        static void Recursij(object x)
        {
            int a = (int)x;
            if (a <= 0)
                return;
            System.Threading.Thread t = new System.Threading.Thread(Recursij);
            t.Name = "Thread" + a;
            t.Start(a - 1);
            Console.WriteLine(t.Name);
        }
        static void Main(string[] args)
        {
            object x = 15;
            Recursij(x);
            Console.ReadKey();
        }
    }
}
