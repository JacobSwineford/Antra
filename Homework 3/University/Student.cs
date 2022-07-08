using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3.University
{
    public class Student : Person
    {

        private List<Course> courses { get; }
        private Dictionary<string, double> grades { get; }

        public Student(string firstName, string lastName) : base(firstName, lastName) 
        {
            courses = new List<Course>();
            grades = new Dictionary<string, double>();
        }

        public void addGrade(string courseName, double grade)
        {
            grades.Add(courseName, grade);
        }

        public void addCourse(Course course)
        {
            courses.Add(course);
        }

        public void removeCourse(Course course)
        {
            courses.Remove(course);
        }

        public double GPA()
        {
            double gpa = 0;
            foreach (string key in grades.Keys)
                gpa += grades[key];
            gpa /= grades.Count;
            return gpa;
        }

        public override decimal salaryFromBase()
        {
            return baseSalary;
        }

        public List<Course> getCourses()
        {
            return courses;
        }

        public Dictionary<string, double> getGrades()
        {
            return grades;
        }


    }
}
