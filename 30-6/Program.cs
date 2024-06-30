using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_6
{
    internal class Program
    {
        //static void Main(string[] args)
        //////{
        //////}

    public class Task1
    {


        public static void Main(string[] args)
        {
            int i, n, sum = 0;
            double avg;
            Console.Write("\n\n");
            Console.Write("Read 10 Numbers and calculate sum and average :\n");
            Console.Write("-------------------------");
            Console.Write("\n\n");

            Console.Write("Input 10 num :\n ");
            for (i = 1; i <= 10; i++)
            {
                Console.Write("Numbers -{0}:", i);
                n = Convert.ToInt32(Console.ReadLine());
                sum += n;

            }
            avg = sum / 10;
            Console.Write("The sum of the 10 numbers :{0}\n", sum, avg);
        }


    }





}
}