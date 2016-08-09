using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> Values = from value in Enumerable.Range(1, 10) select value;
            foreach(int a in Values)
            {
                Console.WriteLine(a);
            }

            Console.ReadLine();
        }
    }
}
