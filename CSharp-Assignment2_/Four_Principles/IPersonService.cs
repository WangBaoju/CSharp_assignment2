using System;
namespace CSharp_Assignment2.Four_Principles
{
	public interface IPersonService
	{
		int CalculateAge();
		decimal CalculateSalary();
        List<string> GetAddresses();
	}
}

