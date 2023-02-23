using System;
namespace CSharp_Assignment2
{
	public class ReverseArray2
	{
		public ReverseArray2()
		{
            //Console.WriteLine("Hello World!");

            Console.WriteLine("Please input the size of of the input array:");
            int size = int.Parse(Console.ReadLine());

            int[] numbers = GenerateNumbers(size);

            Reverse(numbers);

            PrintNumbers(numbers);

            int[] GenerateNumbers(int size)
            {
                int[] numbers = new int[size];
                for (int i = 1; i <= size; i++)
                {
                    numbers[i - 1] = i;
                }

                return numbers;
            }


            void Reverse(int[] array)
            {
                for (int i = 0; i < array.Count() / 2; i++)
                {
                    int temp = array[i];
                    array[i] = array[array.Count() - i - 1];
                    array[array.Count() - i - 1] = temp;
                }
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
}

