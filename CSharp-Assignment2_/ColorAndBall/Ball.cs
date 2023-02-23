using System;
namespace CSharp_Assignment2.ColorAndBall
{
	public class Ball
	{
		private int ballSize { get; set; }
		private Color color { get; set; }

		private int throwCount { get; set; }

		public Ball(int ballSize, Color color)
		{
			this.ballSize = ballSize;
			this.color = color;
			this.throwCount = 0;
		}

		public Ball(int size, int red, int green, int blue, int alpha)
		{
			this.ballSize = size;
			this.color = new Color(red, green, blue, alpha);
            this.throwCount = 0;
        }

        public Ball(int size, int red, int green, int blue)
        {
            this.ballSize = size;
            this.color = new Color(red, green, blue);
            this.throwCount = 0;
        }

		public void Pop()
		{
			this.ballSize = 0;
		}

		public void Throw()
		{
			if(ballSize > 0)
			{
				this.throwCount++;
			}
		}

		public int GetNumberOfThrow()
		{
			return this.throwCount;
		}

		public Color getColor()
		{
			return this.color;
		}

    }
}

