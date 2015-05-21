using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ObligatoryHelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            String hello = "Hello World.";

           Random rnd = new Random();
           char rndChar;

            foreach(Char c in hello)
            {
                do{
                    //Does weird things if not limited to visible characters.
                    rndChar = Convert.ToChar(rnd.Next(32, 126));

                    System.Console.Write(rndChar);
                    Thread.Sleep(5);

                    if (c != rndChar)
                    {
                        Console.Write('\b');
                    }
                } while (c != rndChar);
            }
            Console.Write('\n');
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Please press a key.");
            Console.ReadKey();

        }

        

    }
}
