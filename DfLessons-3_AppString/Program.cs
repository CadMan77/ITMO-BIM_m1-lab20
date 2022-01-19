using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DfLessons_3_AppString
{
    class Program
    {
        static void Main(string[] args)
        {

            StringHelper helper = new StringHelper();
            CountDelegate d1 = helper.GetCount;
            CountDelegate d2 = helper.GetCountSymbolA;

            //string testString = "LAMP";
            string testString = "ABRAKADABRA";

            Console.WriteLine("Общее количества символов: {0}", TestDelegate(d1, testString));
            Console.WriteLine("Количества символов A: {0}", TestDelegate(d2, testString));
            Console.ReadKey();

        }
        static int TestDelegate(CountDelegate method, string testString)
        {
            return method(testString);
        }
        public delegate int CountDelegate(string message);
        public class StringHelper
        {
            public int GetCount(string inputString)
            {
                return inputString.Length;
            }
            public int GetCountSymbolA(string inputString)
            {
                return inputString.Count(c => c == 'A');
            }
            public int GetCountSymbol(string inputString, char symbol)
            {
                return inputString.Count(c => c == symbol);
            }
        }
    }
}
