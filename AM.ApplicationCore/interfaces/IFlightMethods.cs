using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domain;

namespace AM.ApplicationCore.Interface
{
    public interface IFlightMethods
    {
        public IList<DateTime> GetFlightDates(string destinatin);
        public void GetFlights(string filterType, string flightValue);
        public void ShowFlightDetails(Plane plane);
        public int ProgrammedFlightNumber(DateTime startDate);
        public float DurationAverage(string destination);
        public IList<Flight> OrderedDurationFlights();
        //public IList<Traveller> SeniorTravellers(Flight flight);
        public void DestinationGroupedFlights();
    } 
}
