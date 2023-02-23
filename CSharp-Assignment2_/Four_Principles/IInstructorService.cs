using System;
namespace CSharp_Assignment2.Four_Principles
{
	public interface IInstructorService: IPersonService
	{
		bool IsHead();
		int GetYearsOfExperience();
		string GetDepartment();
	}
}

