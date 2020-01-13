using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public static class InputData
    {
        //Lists of the data that user entered-----------------------------------------
        static List<Student> InputStudents = new List<Student>();
        static List<Course> InputCourses = new List<Course>();
        static List<Trainer> InputTrainers = new List<Trainer>();
        static List<Assignment> InputAssignments = new List<Assignment>();
        //----------------------------------------------------------------------------
        //
        //----------------------------------------------------------------------------
        public static void Run() //Input Menu-----------------------------------------
        {
            Console.WriteLine("If you want to insert a course press 1.");
            Console.WriteLine("If you want to insert a trainer press 2.");
            Console.WriteLine("If you want to insert a student press 3.");
            Console.WriteLine("If you want to insert a assigment press 4.");
            Console.WriteLine("To view all the data you inserted press 5.");
            Console.WriteLine("To go to the Main menu type \"Back\"");
            string input = Console.ReadLine();
            Console.WriteLine();

            while ((string)input.ToUpper() != "BACK")
            {
                switch (input)
                {

                    case "1":
                        {
                            CourseInput();
                            break;
                        }
                    case "2":
                        {
                            TrainerInput();
                            break;
                        }
                    case "3":
                        {
                            StudentInput();
                            break;
                        }
                    case "4":
                        {
                            AssignmentInput();
                            break;
                        }
                    case "5":
                        {
                            Manager.ViewStudentList(InputStudents);
                            Manager.ViewTrainerList(InputTrainers);
                            Manager.ViewCourseList(InputCourses);
                            Manager.ViewAssignmentList(InputAssignments);
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
                Console.WriteLine("If you want to insert a course press 1.");
                Console.WriteLine("If you want to insert a trainer press 2.");
                Console.WriteLine("If you want to insert a student press 3.");
                Console.WriteLine("If you want to insert a assigment press 4.");
                Console.WriteLine("To view all the data you inserted press 5.");
                Console.WriteLine("To go to the Main menu type \"Back\"");
                input = Console.ReadLine();
                Console.WriteLine();
            }   
        }

        //Methods for the data input--------------------------------------------------
        static void StudentInput()
        {
            Student stInput = new Student();

            Console.WriteLine("Enter the properties of the student:");
            Console.Write("\tName: ");
                stInput.FirstName = NameInput();
            Console.Write("\tSurname: ");
                stInput.LastName = NameInput();
            Console.Write("\tDate of birt (Must be written like \"dd / MM / yyyy\"): ");
                stInput.DateOfBirth = BirthInput();         
            Console.Write("\tTuition Fees: ");
                stInput.TuitionFees = FloatInput();

            InputStudents.Add(stInput);
            Console.WriteLine("Student is saved!");
        }
        static void TrainerInput()
        {
            Trainer trInput = new Trainer();

            Console.WriteLine("Enter the properties of the trainer:");
            Console.Write("\tName: ");
            trInput.FirstName = NameInput();
            Console.Write("\tSurname: ");
            trInput.LastName = NameInput();
            Console.Write("\tSubject: ");
            trInput.Subject = Console.ReadLine();

            InputTrainers.Add(trInput);
            Console.WriteLine("Trainer is saved!");
        }
        static void CourseInput()
        {
            Course crInput = new Course();

            Console.WriteLine("Enter the properties of the course:");
            Console.Write("\tTitle: ");
            crInput.Title = Console.ReadLine();
            Console.Write("\tStream: ");
            crInput.Stream = Console.ReadLine();
            Console.Write("\tSubject: ");
            crInput.Type = Console.ReadLine();
            Console.Write("\tStart date (Must be written like \"dd / MM / yyyy\"): ");
            crInput.StartDate = DateInput();
            Console.Write("\tEnd date (Must be written like \"dd / MM / yyyy\"): ");
            crInput.EndDate = ExpireInput(crInput.StartDate);

            InputCourses.Add(crInput);
            Console.WriteLine("Course is saved!");

        }

        static void AssignmentInput()
        {
            Assignment asInput = new Assignment();

            Console.WriteLine("Enter the properties of the assignment:");
            Console.Write("\tTitle: ");
            asInput.Title = Console.ReadLine();
            Console.Write("\tDescription: ");
            asInput.Description = Console.ReadLine();
            Console.Write("\tSubmition date (Must be written like \"dd / MM / yyyy\"): ");
            asInput.SubDateTime = DateInput();
            Console.Write("\tOral Marking: ");
            asInput.OralMark = IntInput();
            Console.Write("\tTotal Marking: ");
            asInput.TotalMark = IntInput();

            InputAssignments.Add(asInput);
            Console.WriteLine("Assigment is saved!");
        }
        //----------------------------------------------------------------------------
        //
        //
        
        //----------------------------------------------------------------------------
        public static DateTime DateInput()
        {

            string date = Console.ReadLine();
            DateTime correctDate;
            while (!DateTime.TryParseExact(date, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out correctDate))
            {
                Console.WriteLine("Invalid data input!");
                Console.Write("The date must be written like \"dd / MM / yyyy\"): ");
                date = Console.ReadLine();
            }
            return correctDate;
        }
        public static DateTime ExpireInput(DateTime startDate)
        {
            DateTime input = DateInput();
            while (input < startDate)
            {
                Console.WriteLine("The End date cannot be before the Start date!!");
                Console.Write("Please insert a valid date: ");
                input = BirthInput();
            }
            return input;
        }
        public static DateTime BirthInput()
        {
            DateTime input = DateInput();
            while (input>=DateTime.Now)
            {
                Console.WriteLine("The birth date cannot be in future!!");
                Console.Write("Please insert a valid date: ");
                input = BirthInput();
            }
            return input;
        }
        public static string NameInput()
        {
            bool check;
            string input = Console.ReadLine();

            do
            {
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Name cannot be null!");
                    Console.Write("Put a valid name: ");
                    Console.ReadLine();
                    check = true;
                }
                else if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Name cannot have space!");
                    Console.Write("Put a valid name: ");
                    Console.ReadLine();
                    check = true;
                }
                else if (input.Length < 3)
                {
                    Console.WriteLine("Name must have less than 3 words!");
                    Console.Write("Put a valid name: ");
                    input = Console.ReadLine();
                    check = true;
                }
                else if (input.Length > 20)
                {
                    Console.WriteLine("Name must have more than 25 words!");
                    Console.Write("Put a valid name: ");
                    input = Console.ReadLine();
                    check = true;
                }
                else
                {
                    check = false;
                }
            }
            while (check);
            return input;
        }
        static int IntInput()
        {
            string input = Console.ReadLine();
            int output;

            while (!int.TryParse(input, out output))
            {

                try
                {
                    output = Convert.ToInt32(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("You inserted an invalid number!");


                }
                catch (OverflowException)
                {
                    Console.WriteLine("You inserted a very long number!");
                }
                Console.Write("Enter a valid integer number: ");
                input = Console.ReadLine();
            }
            return output;
        }
        static float FloatInput() 
        {
            string input = Console.ReadLine();
            float output;
            while(!float.TryParse(input,out output))
            {
                Console.WriteLine("You have entered an invalid number!");
                Console.Write("Enter a valid number: ");
                input = Console.ReadLine();
            }
            return output;
            
        }
    }
}

