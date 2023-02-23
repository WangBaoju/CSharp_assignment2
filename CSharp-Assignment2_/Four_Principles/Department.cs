using System;
namespace CSharp_Assignment2.Four_Principles
{
	public class Department:IDepartmentService
	{
        internal string departmentName { get; set; }
        internal string departHead { get; set; }
        internal decimal budgetPerMonth { get; set; }
        internal List<string> offeredCourses { get; set; }

        public string GetHead()
        {
            return departHead;
        }
        public decimal GetBudget(DateTime start, DateTime end)
        {
            return (decimal)((end - start).TotalDays / 30) * budgetPerMonth;
        }
        public List<string> GetOfferedCourses()
        {
            return offeredCourses;
        }
    }
}

