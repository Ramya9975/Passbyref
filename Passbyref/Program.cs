using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Passbyref
{
    internal class Program
    {
        void Add(ref int var)
        {
            var = var + 10;

        }
        void add1(int var1)
        {
            var1++;
            Console.WriteLine(var1);
            

        }
        static void Main(string[] args)
        {
        
            Program p = new Program ();
            int num = 12;
            p.Add(ref num);
            Console.WriteLine(num);
            p.add1(num);
            Console.WriteLine(num);
            Console.ReadLine();
        }
       
    }
}
