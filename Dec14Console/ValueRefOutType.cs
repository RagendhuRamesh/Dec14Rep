using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec14Console
{
    internal class ValueRefOutType
    {
        ////static void Fun1(int insideVar)        ////{
        ////    insideVar = insideVar + 20;
        ////}
        ////static void Fun1(ref int insideVar)        ////{
        ////    insideVar = insideVar + 20;
        ////}
        static void Fun1(out int insideVar)
        {
            insideVar = 0;// must initialize with a value
            insideVar = insideVar + 20;
        }
        static void Main(string[] args)
        {
            //int outsideVar = 10;
            //Fun1( out outsideVar);
            //Console.WriteLine(outsideVar);
            //Console.ReadLine();
            int x = 10;//value type
            Object y;//RT 
            y = x;// boxing

            Console.WriteLine(y);
            Object a = 10;
            // int b;
            int b = (int)a;// unboxing
            Console.WriteLine(b);
            int v1;
            string str1 = "1000";
            bool xyz = int.TryParse(str1, out v1);//will return bool
            int.Parse(str1);//return type int
            Convert.ToInt32(str1);//returns int
            Console.WriteLine(v1);
            Console.WriteLine(xyz);
            Console.ReadLine();
        }
    }
}
