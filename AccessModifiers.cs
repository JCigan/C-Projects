using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Methods
    {
        public static void AccessPublic(string y)
        {
            Console.WriteLine("This is publicly accessible!" + " " + y);
        }

        protected static void AccessProtected(string y)
        {
            Console.WriteLine("Derived Classes may use this!" + " " + y);
        }

        internal static void AccessInternal(string y)
        {
            Console.WriteLine("The current assembly may access this! " + y);
        }
        

        protected internal static void AccessProtectedInternal(string y)
        {
            Console.WriteLine("Access is granted to any namespace that can access either AccessProtected or AccessInternal! " + y);
        }


        private static void AccessRestricted(string y)
        {
            Console.WriteLine("Only this class may access this! " + y);
        }

    }





    class Program
    {
        static void Main(string[] args)
        {
            Methods.AccessPublic("Booya!");
            Methods.AccessInternal("This is usable here!");
            Methods.AccessProtectedInternal("Woohoo!");
        }
    }
}
