using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Assignment
    {
        //Fields--------------------------------
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime SubDateTime { get; set; }
        public int OralMark { get; set; }
        public int TotalMark { get; set; }
        
        //--------------------------------------

        //Constructor---------------------------
        public Assignment() { }
        public Assignment(string title, string descr, string sdt, int oral, int total)
        {
            Title = title;
            Description = descr;
            SubDateTime = DateTime.Parse(sdt);
            OralMark = oral;
            TotalMark = total;
        }
        //--------------------------------------
        /// <summary>
        /// Prints the properties of a assignment
        /// </summary>
        public void ViewSpecs()
        {
            Console.WriteLine("Τίτλος: " + Title);
            Console.WriteLine("Περιγραφή: " + Description);
            Console.WriteLine("Ημερομηνία παράδοσης: " + SubDateTime.ToShortDateString());
            Console.WriteLine("Προφορική βαθμολογία: " + OralMark);
            Console.WriteLine("Συνολική βαθμολογία: " + TotalMark);

        }
    }
}    
