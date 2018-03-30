using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIT_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type something...\n");
            printOnScreen( Console.ReadLine().ToString());
        }
       static void printOnScreen(string str)
        {
            Console.WriteLine("Hello World! " + str);
            Console.ReadKey();
        }
    }
}
