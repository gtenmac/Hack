using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeString
{
    class Program
    {
        static Dictionary<string, string> dic;
        static void Main(string[] args)
        {
            NewDic();
            int i = 0;
            for(i = 0; i < 100; i++)
            {
                Console.WriteLine(dic[(i / 10).ToString()] + dic[(i % 10).ToString()]);
            }
            Console.WriteLine(dic[(i / 100).ToString()] + dic[(i / 10 % 10).ToString()] + dic[(i % 10).ToString()]);
        }
        static void NewDic()
        {
            dic = new Dictionary<string, string>();
            dic.Add("1", "1");
            dic.Add("2", "2");
            dic.Add("3", "A");
            dic.Add("4", "4");
            dic.Add("5", "B");
            dic.Add("6", "6");
            dic.Add("7", "7");
            dic.Add("8", "8");
            dic.Add("9", "C");
            dic.Add("0", "D");
        }
    }
}
