using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            A();
            B();
            C();
            D();
            E();
        }

        public static void A()
        {
            Console.WriteLine("exesuteA");
        }
        public static void B()
        {
            Console.WriteLine("exesuteB");
        }
        public static void C()
        {
            string result;
            //文字列連結

            // 連結演算子を使ったサンプル
            string a = "";
            for (int i = 0; i < 100000; i++)
            {
                a = a + "C#";
            }
            result = a.ToString();

            /*
            // StringBuilderを使ったサンプル
            StringBuilder b = new StringBuilder();
            for (int i = 0; i < 100000; i++)
            {
                b.Append("C#");
            }
            result = b.ToString();
            */

            Console.WriteLine("exesuteC");
        }
        public static void D()
        {
            Console.WriteLine("exesuteD");
        }
        public static void E()
        {
            Console.WriteLine("exesuteE");
        }
    }
}
