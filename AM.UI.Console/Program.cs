using System;
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;
using AM.ApplicationCore.Interface;
using AM.Infrastructure;
using Microsoft.EntityFrameworkCore;


class Program
{
    static void Main()
    {
        Plane plane1 = new Plane();
        plane1.Capacity = 100;
        plane1.ManufactureDate = new DateTime(2024, 05, 23);
        plane1.PlaneType = PlaneType.Airbus;
        plane1.PlaneId = 1;
        Console.WriteLine(plane1.ToString());

        Plane plane2 = new Plane(PlaneType.Boeing, 200, DateTime.Now);
        Console.WriteLine(plane2.ToString());

        Plane plane3 = new Plane {ManufactureDate=DateTime.Now,Capacity=150,PlaneId=3 };
        Console.WriteLine(plane3.ToString());

        Plane plane4 = new Plane { };
        Console.WriteLine(plane4.ToString());
        Passenger passenger = new Passenger { FirstName="Kefi",
									        LastName="YOUSSEF",
									        EmailAddress="youssef.kefi@esprit.tn"
									        };
        Console.WriteLine(passenger.ToString());
        Console.WriteLine(passenger.CheckProfile("Kefi","Youssef"));
        Console.WriteLine(passenger.CheckProfile("Kefi","Yassine"));
        Console.WriteLine(passenger.CheckProfile("Kefi","Youssef","youssef.kefi@esprit.tn"));
        Staff staff1 = new Staff {FirstName="StaffName", LastName="LastNameStaff"};
        Traveller traveller1 = new Traveller {Nationality="Tunisian", FirstName="FirstNameTraveller"};
        passenger.PassengerType();
        staff1.PassengerType();
        traveller1.PassengerType();

        FlightMethods flightMethods = new FlightMethods
        {
            Flights = TestData.listFlights
        };
        foreach (var item in flightMethods.GetFlightDates("Paris"))
        {
            Console.WriteLine(item);
        }
        ///////////QUESTION8
        flightMethods.GetFlights("Destination", "Paris");
        ////QUESTION 10
        flightMethods.ShowFlightDetails(TestData.Airbusplane);
        //question 11
        Console.WriteLine("-----------------------question 11-----------------------");
        Console.WriteLine(flightMethods.ProgrammedFlightNumber(new DateTime(2022, 02, 01, 21, 10, 10)));
        //question 12
        Console.WriteLine("-----------------------question 12-----------------------");
        Console.WriteLine(flightMethods.DurationAverage("Paris"));
        //question 13
        Console.WriteLine("-----------------------question 13-----------------------");
        foreach (var item in flightMethods.OrderedDurationFlights())
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("-----------------------question 14-----------------------");
        foreach (var item in flightMethods.SeniorTravellers(TestData.flight1))
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("-----------------------question 15-----------------------");
        flightMethods.DestinationGroupedFlights();
        Console.WriteLine("-----------------------question 16/17-----------------------");
        flightMethods.FlightDetailsDel(TestData.Airbusplane);
        Console.WriteLine("-----------------------question 16/17 avec delegate-----------------------");
        flightMethods.FlightDetailsDel(TestData.Airbusplane);

        //Console.WriteLine("-----------------------tester la methode d extension-----------------------");
        //Passenger passenger = new Passenger { FirstName = "Youssef", LastName = "Kefi", EmailAddress = "Youssef.kefi@esprit.tn" };
        //Console.WriteLine("avant extension");
        //passenger.UpperFullName();
        //Console.WriteLine("apres extension");
        //Console.WriteLine(passenger.ToString());
        //test atelier 3

        AMContext context=new AMContext();
        context.Flights.Add(TestData.flight2);
        context.SaveChanges();
    }
}

