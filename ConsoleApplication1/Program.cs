using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int result = 0;
            string checkKey = "";
            while (checkKey!="q")
            {
                switch (checkKey)
                {
                    case "q":
                        break;
                    case "r":
                        result = roolDie(rnd, result);
                        result = 0;// make sure the random number less than 6.
                        checkKey = "";//condition for loop, if checkKey="", then continue loop, otherwise checkKey="q" will exit
                        break;
                    default:
                        checkKey = ReadKey(checkKey);
                        break;
                }
            }
        }

        private static int roolDie(Random rnd, int result)
        {
            result += rnd.Next(6) + 1;
            Console.WriteLine("roolDie number: {0}", result);
            return result;
        }

        private static string ReadKey(string readKey)
        {
            Console.WriteLine("Press q to exit or r to rooldie.");
            readKey = Console.ReadLine();
            return readKey;

        }
    }
}
