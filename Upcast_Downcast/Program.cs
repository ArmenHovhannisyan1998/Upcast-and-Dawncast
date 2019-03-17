using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcast_Downcast
{
    class Program
    {
        static void Main(string[] args)
        {
            Derivedclass instance = new Derivedclass();
            instance.Method();
            Console.WriteLine(new string('-',50));

            //Upcast

            Baseclass instanceUP = (Baseclass)instance;
            instanceUP.Method();
            Console.WriteLine(new string('-', 50));

            //Downcast

            Derivedclass instanceDAWN = (Derivedclass)instanceUP;
            instanceDAWN.Method();


            Console.ReadKey();

        }
    }
}
