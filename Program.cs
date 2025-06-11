using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace trycatch
{
    internal class Program
    {
        static void Main(string[] args)
        {

			try
			{
                Console.WriteLine("Please enter a number");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter another number");
                int x = int.Parse(Console.ReadLine());

                int answer = y / x;
                Console.WriteLine(answer);


            }
			catch (Exception ex)
			{

                Console.WriteLine($"error " + ex.Message );

            }
            Console.ReadLine();
        }
    }
}
