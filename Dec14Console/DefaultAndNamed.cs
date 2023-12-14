using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec14Console
{
    internal class DefaultAndNamed
    {
        static void Fun1(int x)
        {
            Console.WriteLine(x);
        }
        static void Adding(int n1, int n2, int n3 = 0, int n4 = 0, int n5 = 0)
        {// default parameters are n3,n4,n5 but not n1,n2 must have values
            double result = n1 + n2 + n3 + n4 + n5;
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            //Fun1();//wrong
            Fun1(10);//correct
            Adding(10, 20);//allows n1,n2
            Adding(10, 20, 30);//n1,n2,n3
            Adding(1, 2, 3, 4, 5);//n1,n2,n3,n4,n5
            Adding(1, 2, 3, 4);//n1,n2,n3
            //named parameters
            Adding(1, 2, n5: 100);//n5 is named parameter

        }
    }
}
