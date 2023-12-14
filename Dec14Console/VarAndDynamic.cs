using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec14Console
{
    public class VarAndDynamic
    {
        public void testingvaranddynamic()
        {
            var s1 = "Hello world";// var is now acts like string type all string class related are visible in 
            int len1 = s1.Length;// Length is property of string  class
            Console.WriteLine("var is early binding with example " + len1);
            dynamic s2 = "hello world";//
            int len2 = s2.Length; //unable to display suggetations, becuase during execution s2 is string
            Console.WriteLine("dynamic late binding " + len2);
            Console.WriteLine(" dynamic   " + s2.Length);
        }
        // keys for main svm press tab key 2 times
        static void Main(string[] args)
        {
            VarAndDynamic vd = new VarAndDynamic();
            vd.testingvaranddynamic();
        }
    }
}
