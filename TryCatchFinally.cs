using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TryCatchFinally
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer: ");
            int integer = Convert.ToInt32(Console.ReadLine());
            
            try
            {
                Console.WriteLine("Three divided by that number: " + 3 / integer);
            }

            catch(Exception e)
            {
                string NewE = e.ToString();
                File.WriteAllText(@"C:\Users\Owner\Documents\log.txt", NewE);
                Console.WriteLine("Uh oh! Error " + e + " occured. Error has been written to log.txt.");
            }
            finally
            {
                Console.WriteLine("Wasn't that fun?");
            }


        }
    }
}
