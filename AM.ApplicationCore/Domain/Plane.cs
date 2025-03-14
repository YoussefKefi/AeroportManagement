﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
	public enum PlaneType { Boeing,Airbus}
	public class Plane 
	{
		[Range(1, int.MaxValue)]
        public int Capacity { get; set;}
		public DateTime ManufactureDate { get; set;}
		public int PlaneId { get; set;}
		public PlaneType PlaneType { get; set;}
		public virtual ICollection<Flight> ListFlights { get; set;}
		public override string ToString()
		{
			return "PlaneId"+this.PlaneId+"Capacity="+this.Capacity;
		}
		public Plane (PlaneType pt, int Capacity, DateTime date)
		{
		this.Capacity = Capacity;
		this.ManufactureDate = date;
		this.PlaneType = pt;
		}
		public Plane() { }
	}
}

