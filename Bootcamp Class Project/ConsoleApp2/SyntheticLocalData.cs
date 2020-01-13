using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class SyntheticLocalData
    {
        public List<Student> studentList;
        public List<Trainer> trainerList;
        public List<Course> courseList;
        public List<Assignment> assignmentList;
        public List<StudentPerCourse> spcList;
        public List<TrainerPerCourse> tpcList;
        public List<AssignmentsPerCourse> apcList;
        public List<AssignmentsPerStudent> apsList;
        public SyntheticLocalData()
        {
            //Student data list-----------------------------------------------------------------------------------
            Student ST1 = new Student("Adam", "Zotiadis", "1996,08,16", 2500);
            Student ST2 = new Student("Albi", "Alikaj", "1998,11,02", 3000);
            Student ST3 = new Student("Alexandros", "Nomikos", "1991,01,14", 1800);
            Student ST4 = new Student("Alexandros", "Perikleous", "1992,05,08", 4000);
            Student ST5 = new Student("Athanasios", "Kontodimas", "1989,09,09", 2420);
            Student ST6 = new Student("Christos", "Vasilakis", "1988,04,24", 5000);
            Student ST7 = new Student("Dionysios", "Pilikas", "1990,05,01", 4810);
            Student ST8 = new Student("Eleni", "Parisi", "1991,02,28", 2250);
            Student ST9 = new Student("Eustathios", "Kanellis", "1986,03,18", 3340);
            Student ST10 = new Student("Evangelos", "Koutsogiorgos", "1992,08,19", 6000);

            studentList = new List<Student>() { ST1, ST2, ST3, ST4, ST5, ST6, ST7, ST8, ST9, ST10 };           
            //------------------------------------------------------------------------------------------------------
            //
            //
            //Trainer data list-------------------------------------------------------------------------------------
            Trainer TR1 = new Trainer("Hector", "Gkatsos", "C# (C sharp)");
            Trainer TR2 = new Trainer("Konstantinos", "Zitis", "Theory and C family");
            Trainer TR3 = new Trainer("Panagiotis", "Bozas", "Code Writing");

            trainerList = new List<Trainer>() { TR1, TR2, TR3 };           
            //------------------------------------------------------------------------------------------------------
            //
            //
            //Course data list--------------------------------------------------------------------------------------
            Course C1 = new Course("CB9","C#","part-time","2019,11,18","2020,06,20");
            Course C2 = new Course("CB8","Java","full-time","2019,02,04,","2020,06,07");
            Course C3 = new Course("CB9", "Java", "part-time", "2019,11,18", "2020,06,20");
            Course C4 = new Course("CB10", "C#", "full-time", "2020,03,01", "2020,07,02");

            courseList = new List<Course>() { C1, C2, C3, C4 };
            //------------------------------------------------------------------------------------------------------
            //
            //
            //Assigment data list-----------------------------------------------------------------------------------
            Assignment AS1 = new Assignment("BriefProject","C# exam","2020,01,17",56,88);
            Assignment AS2 = new Assignment("BriefProject2", "SQL exam", "2020,02,18", 56, 88);
            Assignment AS3 = new Assignment("BriefProject3", "html exam", "2020,03,18", 56, 88);
            Assignment AS4 = new Assignment("BriefProject4", "general exam", "2020,04,19", 56, 88);
            Assignment AS5 = new Assignment("BriefProject5", "final exam", "2020,05,18", 56, 88);
            assignmentList = new List<Assignment>() { AS1,AS2,AS3,AS4,AS5 };
            //----------------------------------------------------------------------------------------------------
            //
            //
            //Data connection
            //Student per Course pairing------------------------------------
            StudentPerCourse SPC1 = new StudentPerCourse(ST1, C1);
            StudentPerCourse SPC2 = new StudentPerCourse(ST2, C1);
            StudentPerCourse SPC3 = new StudentPerCourse(ST3, C2);
            StudentPerCourse SPC4 = new StudentPerCourse(ST4, C2);
            StudentPerCourse SPC5 = new StudentPerCourse(ST5, C3);
            StudentPerCourse SPC6 = new StudentPerCourse(ST6, C3);
            StudentPerCourse SPC7 = new StudentPerCourse(ST7, C4);
            StudentPerCourse SPC8 = new StudentPerCourse(ST8, C4);
            StudentPerCourse SPC9 = new StudentPerCourse(ST9, C3);
            StudentPerCourse SPC10 = new StudentPerCourse(ST10, C2);
            StudentPerCourse SPC11 = new StudentPerCourse(ST1, C2);

            spcList = new List<StudentPerCourse>() { SPC1, SPC2, SPC3, SPC4, SPC5, SPC6,SPC7,SPC8,SPC9,SPC10,SPC11 };
            //-------------------------------------------------------------------------------------------------
            //
            //
            //Trainer per Course pairing-----------------------------------------------------------------------
            TrainerPerCourse TPC1 = new TrainerPerCourse(TR1, C1);
            TrainerPerCourse TPC2 = new TrainerPerCourse(TR2, C2);
            TrainerPerCourse TPC3 = new TrainerPerCourse(TR3, C3);
            TrainerPerCourse TPC4 = new TrainerPerCourse(TR1, C4);

            tpcList = new List<TrainerPerCourse>() { TPC1, TPC2, TPC3, TPC4 };
            //-------------------------------------------------------------------------------------------------
            //
            //
            //Assigment per Course pairing---------------------------------------------------------------------
            AssignmentsPerCourse APC1 = new AssignmentsPerCourse(AS1, C1);
            AssignmentsPerCourse APC2 = new AssignmentsPerCourse(AS2, C2);
            AssignmentsPerCourse APC3 = new AssignmentsPerCourse(AS3, C3);
            AssignmentsPerCourse APC4 = new AssignmentsPerCourse(AS4, C4);
            AssignmentsPerCourse APC5 = new AssignmentsPerCourse(AS5, C1);

            apcList = new List<AssignmentsPerCourse>() { APC1, APC2, APC3, APC4, APC5 };
            //-------------------------------------------------------------------------------------------------
            //
            //
            //Assigment per Student pairing--------------------------------------------------------------------
            AssignmentsPerStudent APS1 = new AssignmentsPerStudent(APC1,ST1);
            AssignmentsPerStudent APS2 = new AssignmentsPerStudent(APC2, ST2);
            AssignmentsPerStudent APS3 = new AssignmentsPerStudent(APC3, ST3);
            AssignmentsPerStudent APS4 = new AssignmentsPerStudent(APC1, ST4);
            AssignmentsPerStudent APS5 = new AssignmentsPerStudent(APC5, ST5);
            AssignmentsPerStudent APS6 = new AssignmentsPerStudent(APC4, ST6);
            AssignmentsPerStudent APS7 = new AssignmentsPerStudent(APC4, ST7);
            AssignmentsPerStudent APS8 = new AssignmentsPerStudent(APC2, ST8);
            AssignmentsPerStudent APS9 = new AssignmentsPerStudent(APC3, ST9);
            AssignmentsPerStudent APS10 = new AssignmentsPerStudent(APC5, ST10);

            apsList = new List<AssignmentsPerStudent>() {APS1,APS2,APS3,APS4,APS5,APS6,APS7,APS8,APS9,APS10 };

        }

        public void SyntheticDataView()
        {
            Console.WriteLine("Listed data:");
            Console.WriteLine("\tTo view all the courses press 1.");
            Console.WriteLine("\tTo view all the trainers press 2.");
            Console.WriteLine("\tTo view all the students press 3.");
            Console.WriteLine("\tTo view all the assigments press 4.");
            Console.WriteLine("Combined data:");
            Console.WriteLine("\tTo view all the students per course press 5.");
            Console.WriteLine("\tTo view all the trainers per course press 6.");
            Console.WriteLine("\tTo view all the assigments per course press 7.");
            Console.WriteLine("\tTo view all the assigments per student press 8.");
            Console.WriteLine("\tTo view which students belong to more than one course press 9.");
            Console.WriteLine("To find which students have to submit their assigment in a specyfic time press 10.");
            Console.WriteLine();
            Console.WriteLine("To go to the Main menu type \"Back\"");
            string input = Console.ReadLine();
            Console.WriteLine();

            while ((string)input.ToUpper() != "BACK")
            {
                switch (input)
                {

                    case "1":
                        {
                            Manager.ViewCourseList(courseList);
                            break;
                        }
                    case "2":
                        {
                            Manager.ViewTrainerList(trainerList);
                            break;
                        }
                    case "3":
                        {
                            Manager.ViewStudentList(studentList);
                            break;
                        }
                    case "4":
                        {
                            Manager.ViewAssignmentList(assignmentList);
                            break;
                        }
                    case "5":
                        {
                            Manager.ViewStudentsPerCourse(spcList,courseList);
                            break;
                        }
                    case "6":
                        {
                            Manager.ViewTrainerPerCourse(tpcList, courseList);
                            break;
                        }
                    case "7":
                        {
                            Manager.ViewSAssignmentsPerCourse(apcList, courseList);
                            break;
                        }
                    case "8":
                        {
                            Manager.ViewAssignmentsPerStudents(apsList);
                            break;
                        }
                    case "9":
                        {
                            Manager.ViewStudentsWithCourses(spcList);
                            break;
                        }
                    case "10":
                        {
                            SubCheck();
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
                Console.WriteLine("Listed data:");
                Console.WriteLine("\tTo view all the courses press 1.");
                Console.WriteLine("\tTo view all the trainers press 2.");
                Console.WriteLine("\tTo view all the students press 3.");
                Console.WriteLine("\tTo view all the assigments press 4.");
                Console.WriteLine("Combined data:");
                Console.WriteLine("\tTo view all the students per course press 5.");
                Console.WriteLine("\tTo view all the trainers per course press 6.");
                Console.WriteLine("\tTo view all the assigments per course press 7.");
                Console.WriteLine("\tTo view all the assigments per student press 8.");
                Console.WriteLine("\tTo view which students belong to more than one course press 9.");
                Console.WriteLine("To find which students have to submit their assigment in a specyfic time press 10.");
                Console.WriteLine();
                Console.WriteLine("To go to the Main menu type \"Back\"");
                input = Console.ReadLine();
                Console.WriteLine();
            }
        }
        //
        //
        //Submition checker-----------------------------------------------------------
        public void SubCheck()
        {
            Console.WriteLine();
            Console.WriteLine("Enter the date to check which studens need to submit one or more assigment in this week.");
            Console.Write("(The date must be written like \"dd / MM / yyyy\"): ");
            DateTime submitionWeek = InputData.DateInput();

            DateTime StartOfWeek;
            DateTime EndOfWeek;

            switch (submitionWeek.DayOfWeek)
            {
                case DayOfWeek.Tuesday: StartOfWeek = submitionWeek.AddDays(-1); EndOfWeek = submitionWeek.AddDays(+3); break;
                case DayOfWeek.Wednesday: StartOfWeek = submitionWeek.AddDays(-2); EndOfWeek = submitionWeek.AddDays(+2); break;
                case DayOfWeek.Thursday: StartOfWeek = submitionWeek.AddDays(-3); EndOfWeek = submitionWeek.AddDays(+1); break;
                case DayOfWeek.Friday: StartOfWeek = submitionWeek.AddDays(-4); EndOfWeek = submitionWeek; break;
                case DayOfWeek.Saturday: StartOfWeek = submitionWeek.AddDays(-5); EndOfWeek = submitionWeek.AddDays(-1); break;
                case DayOfWeek.Sunday: StartOfWeek = submitionWeek.AddDays(-6); EndOfWeek = submitionWeek.AddDays(-2); break;
                default:
                    StartOfWeek = submitionWeek;
                    EndOfWeek = submitionWeek.AddDays(+4);
                    break;

            }
           foreach(var item in apsList)
            {
                if(StartOfWeek<= item.assignmentsandcourse.assignments.SubDateTime && item.assignmentsandcourse.assignments.SubDateTime<=EndOfWeek)
                {
                    Console.WriteLine("Student {0} {1} have to submit teh assignment \"{2}\" until {3}",
                        item.student.FirstName, item.student.LastName, item.assignmentsandcourse.assignments.Title, item.assignmentsandcourse.assignments.SubDateTime);
                }

            }  
           

        }
    }
}
