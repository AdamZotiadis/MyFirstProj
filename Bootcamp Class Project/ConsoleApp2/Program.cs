using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager.Intro();
       
        }
        
    }

    public static class Manager
    {
        public static void Intro()
        {
            Console.WriteLine("To input data press 1.");
            Console.WriteLine("To run the data in internal database press 2.");
            Console.WriteLine("To terminate the app type \"EXIT\"");
            string input = Console.ReadLine();
            Console.WriteLine(); Console.WriteLine();
            while ((string)input.ToUpper() != "EXIT")
            {

                switch (input)
                {

                    case "1":
                        {
                            InputData.Run();
                            break;
                        }
                    case "2":
                        {
                            SyntheticLocalData sa = new SyntheticLocalData();
                            sa.SyntheticDataView();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Incorrect value, please read carefully the menu.");
                            Console.WriteLine();
                            Console.WriteLine();

                            break;
                        }
                }
                Console.WriteLine();
                Console.WriteLine("To input data press 1.");
                Console.WriteLine("To run the data in internal database press 2.");
                Console.WriteLine("To terminate the app type \"EXIT\"");
                input = Console.ReadLine();
                Console.WriteLine(); Console.WriteLine();
            }
        }
        //
        //Methods to view the data from lists-----------------------------------------
        public static void ViewStudentList(List<Student> list)
        {
            Console.WriteLine("\t\tStudent List");
            foreach (var item in list)
            {
                item.ViewSpecs();
                Console.WriteLine();
            }
        }
        public static void ViewTrainerList(List<Trainer> list)
        {
            Console.WriteLine("\t\tTrainer List");
            foreach (var item in list)
            {
                item.ViewSpecs();
                Console.WriteLine();
            }
        }
        public static void ViewCourseList(List<Course> list)
        {
            Console.WriteLine("\t\tCourse List");
            foreach (var item in list)
            {
                item.ViewSpecs();
                Console.WriteLine();
            }
        }
        public static void ViewAssignmentList(List<Assignment> list)
        {
            Console.WriteLine("\t\tAssignment List");
            foreach (var item in list)
            {
                item.ViewSpecs();
                Console.WriteLine();
            }
        }
        //
        //View of the collerated data--------------------------------------------------
        public static void ViewStudentsPerCourse(List<StudentPerCourse> list,List<Course> courseList)
        {
            
            
            foreach (var c in courseList)
            {

                
                Console.WriteLine("\t" + c.Title +" "+c.Stream + " " +c.Type);
                Console.WriteLine();
                foreach (var item in list)
                {
                    if (item.course.Equals(c))
                    {
                        Console.WriteLine("\t\t" + item.student.FirstName + " " + item.student.LastName);
                        Console.WriteLine();
                    }
                }
            }
        }   
                   
                    
              
        
        public static void ViewTrainerPerCourse(List<TrainerPerCourse> list,List<Course> courseList)
        {
            foreach (var c in courseList)
            {


                Console.WriteLine("\t" + c.Title + " " + c.Stream + " " + c.Type);
                Console.WriteLine();
                foreach (var item in list)
                {
                    if (item.course.Equals(c))
                    {
                        Console.WriteLine("\t\t" + item.trainer.FirstName + " " + item.trainer.LastName);
                        Console.WriteLine();
                    }
                }
            }
        }
        public static void ViewSAssignmentsPerCourse(List<AssignmentsPerCourse> list, List<Course> courseList)
        {
            foreach (var c in courseList)
            {


                Console.WriteLine("\t" + c.Title + " " + c.Stream + " " + c.Type);
                Console.WriteLine();
                foreach (var item in list)
                {
                    if (item.courses.Equals(c))
                    {
                        Console.WriteLine("\t\t" + item.assignments.Title);
                        Console.WriteLine();
                    }
                }
            }
        }
        public static void ViewAssignmentsPerStudents(List<AssignmentsPerStudent> list)
        {
            foreach (var item in list)
            {

                item.OutputAssignmentsOfStudent();
            }
        }
        public static void ViewStudentsWithCourses(List<StudentPerCourse> list)
        {
            foreach (var c in list)
            {

                if (c.student.Courses.Count > 1)
                {
                    Console.WriteLine("\t"+c.student.FirstName+" "+c.student.LastName);
                    c.OutputCourses();
                }
            }
        }
        
    }
    
}
