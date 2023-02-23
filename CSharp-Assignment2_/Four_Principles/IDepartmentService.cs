using System;
namespace CSharp_Assignment2.Four_Principles
{
	public interface IDepartmentService
	{
		string GetHead();
		decimal GetBudget(DateTime start, DateTime end);
		List<string> GetOfferedCourses();

	}
}

