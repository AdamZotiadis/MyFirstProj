using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Course
    {
        //Fields-----------------------------------
        public string Title { get; set; }
        public string Stream { get; set; }
        public string Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public List<Student> students = new List<Student>();
        public List<Trainer> trainers = new List<Trainer>();
        public List<Assignment> assignments = new List<Assignment>();
        //-----------------------------------------

        //Constructors-----------------------------
        public Course() { }
        public Course(string Title, string Stream, string Type, string StartDate, string EndDate)
        {
            this.Title = Title;
            this.Stream = Stream;
            this.Type = Type;
            this.StartDate = DateTime.Parse(StartDate);
            this.EndDate = DateTime.Parse(EndDate);
        }
        //------------------------------------------
        /// <summary>
        /// Prints the properties of a course
        /// </summary>
        public void ViewSpecs()
        {
            Console.WriteLine("Τίτλος σειράς μαθημάτων: "+ Title);
            Console.WriteLine("Ονομασία μαθήματος: " + Stream);
            Console.WriteLine("Τύπος σειράς μαθήματος: " + Type);
            Console.WriteLine("Ημερομηνία εκκίνησης μαθημάτων: " + StartDate.ToShortDateString());
            Console.WriteLine("Ημερομηνία λήξης μαθημάτων: " + EndDate.ToShortDateString());
            
        }

    }
    //Correlation between students and courses
    public class StudentPerCourse   
    {

        public Student student;
        public Course course; 

        public StudentPerCourse(Student student, Course course)
        {
            this.course = course;
            this.student = student;
            student.Courses.Add(course);  
            course.students.Add(student); 
        }
        /// <summary>
        /// Prints the students in a course
        /// </summary>
        public void OutputStudents()
        {
            foreach (var c in course.Title){
                Console.WriteLine("\t" + c);
                Console.WriteLine();
                foreach (var item in course.students)
                {
                    Console.WriteLine("\t\t" + item.FirstName + " " + item.LastName);
                    Console.WriteLine();
                }
            }
        }
        /// <summary>
        /// Prints the courses per student
        /// </summary>
        public void OutputCourses()
        {
                
                    course.ViewSpecs();
                    Console.WriteLine();                        
        }
    }

    public class TrainerPerCourse
    {

        public Trainer trainer;
        public Course course;

        public TrainerPerCourse(Trainer trainer, Course course)
        {
            this.course = course;
            this.trainer = trainer;

            course.trainers.Add(trainer);
        }
        /// <summary>
        /// Prints the trainers in a course
        /// </summary>
        public void OutputTrainers()
        {
            Console.WriteLine("\t" + course.Title);
            Console.WriteLine();
            foreach (var item in course.trainers)
            {
                item.ViewSpecs();
                Console.WriteLine();
            }
            
        }
        
    }

    public class AssignmentsPerCourse
    {
        public Assignment assignments;
        public Course courses;
        
        public AssignmentsPerCourse(Assignment assignment, Course course)
        {
            assignments = assignment;
            courses = course;
            course.assignments.Add(assignment);
        }
        /// <summary>
        /// Prints the assigment in a course
        /// </summary>
        public void OutputAssignments()
        {
            Console.WriteLine("\t" + courses.Title);
            Console.WriteLine();
            foreach (var item in courses.assignments)
            {
                item.ViewSpecs();
                Console.WriteLine();
            }
            
        }

    }

}
