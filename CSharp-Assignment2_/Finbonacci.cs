using System;
namespace CSharp_Assignment2
{
	public class Finbonacci
	{
		public Finbonacci()
		{
            Console.WriteLine("Please input the number for the Fibonacci sequence:");
            int num = int.Parse(Console.ReadLine());

			int[] fibonacciNumbers = GenerateFibonacci(num);

			PrintNumbers(fibonacciNumbers);
        }

		int[] GenerateFibonacci(int num)
		{
			int[] res = new int[num];
            int a = 1; int b = 1;int c;
            
            for(int i = 0; i < num; i++)
            {
                res[i] = a;
                c = a + b;

                a = b;
                b = c;
            }
            return res;
		}

        void PrintNumbers(int[] array)
        {
            for (int i = 0; i < array.Count() - 1; i++)
            {
                Console.Write(array[i] + ", ");
            }
            Console.Write(array[array.Count() - 1]);
        }

    }
}

