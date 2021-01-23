using System;

namespace Dic
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDic<int, string> days = new MyDic<int, string>();
            days.Add(1, "Pazartesi");
            days.Add(2, "Salı");

            Console.WriteLine(days.Count);
            days.Add(3, "Çarş");

            for (int i = 0; i < days.Count; i++)
            {
                Console.WriteLine("[" + days.Keys[i] + ": " + days.Values[i] + "] ");
            }
        }
    }
}
