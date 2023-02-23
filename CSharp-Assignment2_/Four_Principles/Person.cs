using System;
namespace CSharp_Assignment2.Four_Principles
{
	public abstract class Person:IPersonService
	{
		internal string name { get; set; }
        internal DateTime dateOfBirth { get; set;}
        internal decimal hourlyPay { get; set; }
        internal int workHours { get; set; }

        internal List<string> addresses { get; set; }

        public abstract int CalculateAge();
        public abstract decimal CalculateSalary();
        public abstract List<string> GetAddresses();
    }
}

