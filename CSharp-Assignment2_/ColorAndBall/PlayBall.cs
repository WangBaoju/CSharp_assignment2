using System;
namespace CSharp_Assignment2.ColorAndBall
{
	public class PlayBall
	{
		public PlayBall()
		{
            Ball ball1 = new(10, 255, 0, 0);
            Ball ball2 = new(10, 255, 128, 0);
            Ball ball3 = new(10, 255, 255, 0);
            Ball ball4 = new(10, 128, 255, 0);
            Ball ball5 = new(10, 0, 255, 255);
            Ball ball6 = new(10, 0, 0, 255);
            Ball ball7 = new(10, 128, 0, 255);

            Console.WriteLine($"The throw count for all balls before: ");
            Console.WriteLine($"Ball1: {ball1.GetNumberOfThrow()}");
            Console.WriteLine($"Ball2: {ball2.GetNumberOfThrow()}");
            Console.WriteLine($"Ball3: {ball3.GetNumberOfThrow()}");
            Console.WriteLine($"Ball4: {ball4.GetNumberOfThrow()}");
            Console.WriteLine($"Ball5: {ball5.GetNumberOfThrow()}");
            Console.WriteLine($"Ball6: {ball6.GetNumberOfThrow()}");
            Console.WriteLine($"Ball7: {ball7.GetNumberOfThrow()}");

            ball1.Throw();
            ball2.Throw();
            ball5.Throw();
            ball3.Pop();
            ball4.Throw();
            ball7.Throw();
            ball6.Throw();
            ball1.Throw();
            ball2.Pop();
            ball5.Throw();
            ball7.Throw();
            ball1.Throw();
            ball2.Throw();
            ball7.Pop();
            ball4.Throw();

            Console.WriteLine($"The throw count for all balls after: ");
            Console.WriteLine($"Ball1: {ball1.GetNumberOfThrow()}");
            Console.WriteLine($"Ball2: {ball2.GetNumberOfThrow()}");
            Console.WriteLine($"Ball3: {ball3.GetNumberOfThrow()}");
            Console.WriteLine($"Ball4: {ball4.GetNumberOfThrow()}");
            Console.WriteLine($"Ball5: {ball5.GetNumberOfThrow()}");
            Console.WriteLine($"Ball6: {ball6.GetNumberOfThrow()}");
            Console.WriteLine($"Ball7: {ball7.GetNumberOfThrow()}");
        }
	}
}

