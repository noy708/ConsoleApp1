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
            int lineCount = 10000;
            string[] lines = Import(lineCount);
            string text = Concat(lines);
            Output(text);
        }

        // 各行を取り込む
        public static string[] Import(int lineCount)
        {
            string[] lines = new string[lineCount];
            for (int i = 0; i < lineCount; i++)
            {
                lines[i] = "sample";
            }
            return lines;
        }

        // 各行を連結する
        public static string Concat(string[] lines)
        {
            string text = "";
            for (int i = 0; i < lines.Length; i++)
            {
                text += lines[i];
            }
            return text;
        }

        // 文章を出力する
        public static void Output(string text)
        {
            Console.WriteLine(text);
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
            for (int i = 0; i < 10000; i++)
            {
                a = a + "C#";
            }
            result = a.ToString();

            /*
            // StringBuilderを使ったサンプル
            StringBuilder b = new StringBuilder();
            for (int i = 0; i < 10000; i++)
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
