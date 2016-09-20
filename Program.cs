using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Dictionary_slide22
{
    class Program
    {
        private static int has;

        public static bool Bear { get; private set; }

        static void Main(string[] args)
        {
            /* Create a the following Dictionary:
             Dictionary<string, int> animals = new Dictionary<string, int>();
             Add 6 animals in the following format
             animals.Add("Bear", 4);
             animals.Add("Squid", 10);
             animals.Add("Bird", 2);
             “ ”
             “ ”
             “ ”
             Run queries against the dictionary in the following format.Test different animals.Try animals that aren’t in the dictionary.

             if (dictionary.ContainsKey("Bear"))
             {
                 int value = dictionary["Bear"];
                 Console.WriteLine(“Bear has ” +value + ” legs.”);
             }


             How can we make the previous queries more efficient to use ?*/

            Dictionary<string, int> animals = new Dictionary<string, int>();
            animals.Add("Bear", 4);
            animals.Add("Squid", 10);
            animals.Add("Bird", 2);
            animals.Add("Dog", 4);
            animals.Add("Frog", 2);
            animals.Add("Squirrel", 4);

            if (animals.ContainsKey("Bear"))
            {
                int value = animals["Bear"];
                Console.WriteLine("Bear has" +value +" legs.");
            }
            Console.ReadKey();
             
        }
    }
}
