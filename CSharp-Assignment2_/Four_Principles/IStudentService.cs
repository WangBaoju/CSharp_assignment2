using System;
namespace CSharp_Assignment2.Four_Principles
{
	public interface IStudentService:IPersonService
	{
		double CaculateGPA();
		char GetGrade(string course);
	}
}

