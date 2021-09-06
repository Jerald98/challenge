using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the n:");
            int n = Convert.ToInt32(Console.ReadLine());
            double z = 0;
            double k = 0;
            double sum = 0;
            for (int i = 1; i <=n; i++)
            {
                string x = Convert.ToString(Console.ReadLine());
                string[] s = x.Split();
                string r = s[0];
                string g = s[1];
                string y = s[2];
                z = concate(r, g, y);
                 sum +=z;
                 k = sum / i;
                 Console.WriteLine(k);
              }
        }

        public static int concate(string r, string g, string y)
        {
            string s = r + g + y;
            int a = Convert.ToInt32(s);
            return a;
        }
    }

}
    

