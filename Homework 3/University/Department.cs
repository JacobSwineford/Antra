using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3.University
{
    public class Department
    {
        private Instructor head { get; set; }
        private Dictionary<DateRange, double> budgets { get; }
        private Dictionary<int, Course> coursesOffered { get; }

        public Department(Instructor head)
        {
            this.head = head;
            budgets = new Dictionary<DateRange, double>();
            coursesOffered = new Dictionary<int, Course>();
        }

        public void setBudget(DateRange dr, double budget)
        {
            budgets.Add(dr, budget);
        }

        public void setOfferedCourses(int year, Course course) 
        {
            coursesOffered.Add(year, course);
        }

        public Instructor getHead() { return head; }
        public Dictionary<DateRange, double> getBudgets() { return budgets; }
        public Dictionary<int, Course> getCoursesOffered() { return coursesOffered; }
        public void setHead(Instructor head) { this.head = head; }
    }

    // can be expanded upon
    public class DateRange
    {
        private DateTime start { get; set; }
        private DateTime end { get; set; }

        public DateRange(DateTime start, DateTime end)
        {
            this.start = start;
            this.end = end;
        }
    }
}
