using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Abc
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char[] ch=s.ToCharArray();
           //Console.WriteLine(s[s.Length-1]);
            if ((System.Convert.ToInt32(ch[ch.Length - 1]) + 1) <=122)
            {
                foreach (char c in s)
                {
                    Console.Write(System.Convert.ToChar(c + 1));
                }
            }
            else
            {
                Console.WriteLine("error");
            }
           
        }
    }
}
