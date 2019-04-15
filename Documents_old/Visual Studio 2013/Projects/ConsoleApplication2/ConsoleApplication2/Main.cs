using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Main
    {
        public delegate string rak(int x,int y);
        public string con(int x,int y)
        {
            String s = " ";
            Console.WriteLine(s + x + y);
            return s + x + y;
        }
        public String se(int x,int y)
        {
            int z = x + y;
            string s = " ";
            
            return z+s;
        }
        static void Main(string[] args)
        {
            Main p = new Main();
            rak r = new rak(p.con);
            r += p.se;
            string m= r.Invoke(10, 11);
            Console.WriteLine(m);


            //Thread t = new Thread();

        }
    }
}
