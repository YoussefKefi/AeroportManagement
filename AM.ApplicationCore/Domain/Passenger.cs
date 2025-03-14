using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
	public class Passenger
	{
		//public int Passengerid { get; set; }
		[Display(Name = "Date de birth")]
		[DataType(DataType.DateTime)]
        public DateTime BirthDate{ get; set;}
		[DataType(DataType.EmailAddress)]
        public String EmailAddress { get; set;}
		public FullName FullName { get; set;}
		[Key]
		[StringLength(7)]
        public String PassportNumber{ get; set;}
		[RegularExpression(@"^[0-9]{8}$", ErrorMessage = "le numero de telephone doit contenir 8 chiffres")]
        public String TelNumber { get; set;}
        //public ICollection<Flight> Flights { get; set;}
        public virtual ICollection<Ticket> ListTickets { get; set; }

        public override string ToString()
		{
			return "FirstName"+this.FullName.FirstName+"LastName="+this.FullName.LastName;
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
				return this.FullName.FirstName == FirstName && this.FullName.LastName == LastName;
			 }
			else
			{
				return this.FullName.FirstName == FirstName && this.FullName.LastName == LastName && this.EmailAddress == Email;
			}
		}
		public virtual void PassengerType ()
		{
			Console.WriteLine("I'm a passenger");

		}
	}
}

