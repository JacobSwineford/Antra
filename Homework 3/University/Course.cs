using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3.University
{
    public class Course
    {
        private List<Student> enrolledStudents { get; }
        private Dictionary<Student, double> grades { get; }
        string courseName { get; set; }

        public Course(string courseName)
        {
            enrolledStudents = new List<Student>();
            grades = new Dictionary<Student, double>();
            this.courseName = courseName;
        }

        public void addStudent(Student student)
        {
            enrolledStudents.Add(student);
        }

        public void removeStudent(Student student)
        {
            enrolledStudents.Remove(student);
        }

        public List<Student> getEnrolledStudents() { return enrolledStudents; }
        public Dictionary<Student, double> getGrades() { return grades; }
        public string getCourseName() { return courseName; }
        public void setCourseName(string name) { courseName = name; }
    }
}
