using System;
namespace CSharp_Assignment2.Four_Principles
{
	public class Course:ICourseService
	{
		internal string courseName { get; set; }
		internal int credit { get; set; }
		internal List<Student> enrolledStudents { get; set;}
		internal char grade { get; set; }


        public List<string> GetEnrolledStudents()
		{
			List<string> list = new List<string>();
			foreach(var student in enrolledStudents)
			{
				list.Add(student.name);
			}
			return list;
		}

    }
}

