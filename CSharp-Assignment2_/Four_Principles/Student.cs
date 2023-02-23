using System;
namespace CSharp_Assignment2.Four_Principles
{
	public class Student : Person, IStudentService
    {
        internal int studentId { get; set; }
        internal string departmentBelongs { get; set; }
		internal List<Course> courses { get; set; }
        
        public double CaculateGPA()
        {
            int numberOfCourses = courses.Count;
            double scores = 0.0;
            foreach(var course in courses){
                if (course.grade == 'A') scores += 4.0;
                if (course.grade == 'B') scores += 3.3;
                if (course.grade == 'C') scores += 2.3;
                if (course.grade == 'D') scores += 1.3;
                if (course.grade == 'E') scores += 1.0;
                if (course.grade == 'F') scores += 0.0;
            }
            double gpa = scores / numberOfCourses;
            return gpa;
        }
        public char GetGrade(string course)
        {
            for(int i = 0; i < courses.Count(); i++)
            {
                if (courses[i].courseName == course) return courses[i].grade;
            }
            return '0';
        }

        public override int CalculateAge()
        {
            return DateTime.Today.Year - base.dateOfBirth.Year;
        }

        public override decimal CalculateSalary() {
            return base.hourlyPay * base.workHours;
        }
        public override List<string> GetAddresses() {
            return base.addresses;
        }

    }
}

