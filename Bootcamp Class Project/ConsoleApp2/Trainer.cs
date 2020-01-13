using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Trainer
    {
        //Fields--------------------------------
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Subject;
        
        //--------------------------------------

        //Constructor---------------------------
        public Trainer() { }
        public Trainer(string fname,string lname, string subject)
        {
            FirstName = fname;
            LastName = lname;
            Subject = subject;
        }
        //--------------------------------------

        public void ViewSpecs()
        {
            Console.WriteLine("Ονοματεπώνυμο: {0} {1}", FirstName, LastName);
            Console.WriteLine("Εκπαιδευτής στο μάθημα: " + Subject);
                  
        }
    }

}
