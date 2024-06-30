using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_6___2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number To Find The Cube: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"The cube Of {i} IS : {i * i * i}");
            }

            Console.WriteLine("----------------------------------------------------------");

        }


    }
}
