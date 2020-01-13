using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Student
    { 
        //Fields--------------------------------
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public float TuitionFees { get; set; }

        public List<AssignmentsPerCourse> Assign = new List<AssignmentsPerCourse>();
        public List<Course> Courses = new List<Course>();
        //--------------------------------------

        //Constructors--------------------------
        public Student() { }
        public Student(string fname, string lname, string dob, float fees) 
        {
            FirstName = fname;
            LastName = lname;
            DateOfBirth = DateTime.Parse(dob);
            TuitionFees = fees;

           
    }
        //--------------------------------------
        public void ViewSpecs()
        {
            Console.WriteLine("Ονοματεπώνυμο: {0} {1}",FirstName, LastName);
            Console.WriteLine("Ημερομηνία γέννησης: "+DateOfBirth.ToShortDateString());
            Console.WriteLine("Κόστος εκπαίδευσης: "+TuitionFees);
        }
    }
    public class AssignmentsPerStudent
    {
         public AssignmentsPerCourse assignmentsandcourse;
         public Student student;

        public AssignmentsPerStudent(AssignmentsPerCourse assignments, Student student)
        {
            assignmentsandcourse = assignments;
            this.student = student;
            student.Assign.Add(assignments);
        }
        public void OutputAssignmentsOfStudent()
        {
            Console.WriteLine("\t"+student.FirstName +" "+student.LastName);
            Console.WriteLine();
            foreach (var assign in student.Assign)
            {
                assign.assignments.ViewSpecs();
            }
            Console.WriteLine();
        }



    }
}
