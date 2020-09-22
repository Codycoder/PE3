using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
		
				int num = 6;
				List<int> primeFactors = new List<int>();

			for (var i = 1; i < num; i++)
			{
				int factor = num / 2;
				//primeFactors.Add(2);

				if (factor > 3)
				{
					factor = num / 2;
					primeFactors.Add(2);
				}
				else if (factor == 2)
				{
					primeFactors.Add(2);
				}

				else if (factor == 3)
				{
					primeFactors.Add(3);
					break;
				}
				

				foreach (var item in primeFactors)
				{
					Console.WriteLine(item);

				}
			}
			
		}
    }
}
