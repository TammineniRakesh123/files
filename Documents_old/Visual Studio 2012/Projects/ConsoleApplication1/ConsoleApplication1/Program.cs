﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char[] ch=s.ToCharArray();
            if ((System.Convert.ToInt32(ch[ch.Length - 1]) + 1) <=122)
            {
                foreach (char c in s)
                {
                    Console.Write((char)(c + 1));
                }
            }
            else
            {
                Console.WriteLine("error");
            }
            Console.ReadLine();
        }
       
    }
}
