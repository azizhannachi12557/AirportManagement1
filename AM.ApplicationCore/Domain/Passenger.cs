using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {


        public string PassportNumber { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }
        public int? TelNumber { get; set; }
        public string? EmailAddress { get; set; }

        public  IList<Flight> Flights { get; set; }

        public override string ToString()
        {
            return "FirstName: " + FirstName + " LastName: " + LastName + " date of Birth: " + BirthDate;
        }
          //PLYMORphisme par signature
       public bool checkProfile(string nom,string prenom) {
            if( (FirstName==nom)&& (LastName==prenom))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool checkProfile(string nom, string prenom, string email)
        {
            if ((FirstName == nom) && (LastName == prenom) && (EmailAddress == email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool login(string nom, string prenom, string email)
        {
            if(email !=null)
            
                return checkProfile(nom, prenom, email);
                return checkProfile(nom, prenom);


            
        }
        public virtual void PassengerType()
        {
            Console.WriteLine("i am passenger");
        }
    }
    }

