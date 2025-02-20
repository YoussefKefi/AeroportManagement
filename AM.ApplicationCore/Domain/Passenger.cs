using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
	public class Passenger
	{
		public DateTime BirthDate{ get; set;}
		public String EmailAddress { get; set;}
		public String FirstName { get; set;}
		public String LastName { get; set;}
		public String PassportNumber{ get; set;}
		public String TelNumber { get; set;}
		public ICollection<Flight> Flights { get; set;}
		public override string ToString()
		{
			return "FirstName"+this.FirstName+"LastName="+this.LastName;
		}
	        //public bool CheckProfile(string Firstname, String Lastname, String email)
        //{
        //    if (Firstname == FirstName && Lastname == LastName && email == EmailAddress)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
		public bool CheckProfile (String FirstName, String LastName, String Email=null) 
		{
			if ( Email == null) 
			{
				return this.FirstName == FirstName && this.LastName == LastName;
			 }
			else
			{
				return this.FirstName == FirstName && this.LastName == LastName && this.EmailAddress == Email;
			}
		}
		public virtual void PassengerType ()
		{
			Console.WriteLine("I'm a passenger");

		}
	}
}

