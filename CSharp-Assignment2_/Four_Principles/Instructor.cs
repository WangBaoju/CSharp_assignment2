using System;
namespace CSharp_Assignment2.Four_Principles
{
	public class Instructor : Person, IInstructorService
	{
		internal int wordId { get; set; }

		internal string instructorName { get; set; }

		internal string department { get; set; }

		internal DateTime joinDate { get; set; }

		internal bool isHead { get; set; }
		

		public bool IsHead()
		{
			return isHead;
		}

		public int GetYearsOfExperience()
		{
			return DateTime.Today.Year - joinDate.Year;
		}

		public override int CalculateAge()
		{
			return DateTime.Today.Year - base.dateOfBirth.Year;
		}

		public decimal CaculateBonus()
		{
			return GetYearsOfExperience() * (decimal)0.02 * base.hourlyPay;

		}
		public override decimal CalculateSalary()
		{
			return base.workHours * base.hourlyPay + CaculateBonus();

		}
		public override List<string> GetAddresses()
		{
			return addresses;
		}

		public string GetDepartment()
		{
			return department;
		}
	}

}