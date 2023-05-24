using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Console.Models
{
    internal class Interviewer
    {
        public int InterviewerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public string Email {

            get 
            {
                return FirstName.Substring(0, 1) + "." + LastName + "@"
                    + UtilityFunctions.SubDomains[new Random().Next(UtilityFunctions.SubDomains.Length)]
                    + "." + UtilityFunctions.Domains[new Random().Next(UtilityFunctions.Domains.Length)]; 
            }

            // set;
        }
    }
}
