using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> names = new MyDictionary<int, string>();
            names.Add(1, "Selim");
            names.Add(10, "Sueda");
            names.Add(24, "Çağlar");
            names.Add(12, "Mustafa");
            names.Add(101, "Gökçe");
            names.Add(999, "Altay");

            names.Values(999);
            Console.ReadLine();
        }
    }
}
