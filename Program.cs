using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveZeroNegative
{
    class Solution
    {
        static void Main(String[] args)
        {
            double t = Convert.ToInt32(Console.ReadLine());
            double pos = 0, zeros = 0, negs = 0;


            String elements = Console.ReadLine();
            String[] split_elements = elements.Split(' ');

            foreach (string element in split_elements)
            {
                int number = Convert.ToInt32(element);
                if (number < 0) { negs++; }
                else if (number == 0) { zeros++; }
                else { pos++; }
            }
            double positives = (pos / t);
            double zeross = (zeros / t);
            double negatives = (negs / t);

            Console.WriteLine(positives.ToString("0.000000"));
            Console.WriteLine(negatives.ToString("0.000000"));
            Console.WriteLine(zeross.ToString("0.000000"));
            Console.ReadLine();

        }
    }
}