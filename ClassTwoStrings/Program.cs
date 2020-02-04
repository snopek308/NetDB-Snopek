using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTwoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Jimmy";
            string address = "123 Pine St";
            var pi = Math.PI;

            Console.WriteLine("Jimmy");
            Console.WriteLine("{0}", name);
            Console.WriteLine($"{name}");
            Console.WriteLine("|{0}|{1}|", "Jimmy", "123 Pine St");
            
            //Positive: right aligned
            Console.WriteLine("|{0,-8}|{1, 12}|", "Jimmy", "123 Pine St");
            Console.WriteLine("|{0,-4}|{1, 12}|", name, address);
            Console.WriteLine("|{0,4}|{1, 12}|", name, address);

            //to five decimals
            Console.WriteLine($"{pi:n5}");

        }
    }
}
