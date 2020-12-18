
using System;
using System.Collections.Generic;


public class Booking
{

	

	public static void Main(string[] args)
	{
		

		IList<Flights> flights = new List<Flights>();
     
		do
		{


		Console.WriteLine("***********************");
		Console.WriteLine("Flight Booking Manager");
		Console.WriteLine("***********************");
		Console.WriteLine("Please type '1' to add a flight");
		Console.WriteLine("Please type '2' to check the available flights");
		Console.WriteLine("Please type '3' to check the available free places in a specific flight");
		Console.WriteLine("Please type '4' to book flight for a passenger");
		Console.WriteLine("Please type '5' to calculate the price of the booking flight for a passenger");
		Console.WriteLine("Please type '6' to check the services available for the VIP passengers");
        
            int choix = Convert.ToInt32(Console.ReadLine());

            switch (choix)
		{
		  case 1:
			  addFlight((List<Flights>)flights);
			break;
		  case 2:
			  Console.WriteLine("To print all the available flights type: 1");
			  Console.WriteLine("To print all the available flights for a specific destination type: 2");
			  Console.WriteLine("To print all the available flights for a specific destination from a specific point of depart type: 3");
			  Console.WriteLine("To print all the available flights for a specific date: 4");
			  Console.WriteLine("To print all the available flights for a specific destination from a specific point of depart type for a specific date: 5");
			  Console.WriteLine("To print all the available flights for a specific destination from a specific point of depart type for a specific date: 6");
			  int c = Convert.ToInt32(Console.ReadLine());
                    switch (c)
			  {
				  case 1:
				  availableFlights((List<Flights>)flights);
				  break;

				  case 2:
					  Console.WriteLine("enter the destination: ");
					  string des = Convert.ToString(Console.ReadLine());
                            availableFlights((List<Flights>)flights, des);
			  break;

				case 3:
					Console.WriteLine("enter the destination: ");
					  string des1 = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("enter the point of the depart: ");
					  string dep = Convert.ToString(Console.ReadLine());
                            availableFlights((List<Flights>)flights, dep, des1);
			  break;

				case 4:
					Console.WriteLine("enter the year of the flight: ");
					int year = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("enter the month of the flight: ");
					int month = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("enter the day of the flight: ");
					int day = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("enter the hour of the flight: ");
					int hour = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("enter the minutes of the flight: ");
					int minutes = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("enter the senconds of the flight: ");
                            int seconds = Convert.ToInt32(Console.ReadLine());
                            DateTime calendar = new DateTime(year, month, day, hour, minutes, seconds);
					availableFlights((List<Flights>)flights, calendar);
					break;

				case 5:
                            Console.WriteLine("enter the year of the flight: ");
                            int yeari = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("enter the month of the flight: ");
                            int monthi = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("enter the day of the flight: ");
                            int dayi = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("enter the hour of the flight: ");
                            int houri = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("enter the minutes of the flight: ");
                            int minutesi = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("enter the senconds of the flight: ");
                            int secondsi = Convert.ToInt32(Console.ReadLine());
                            DateTime calendarr = new DateTime(yeari, monthi, dayi, houri, minutesi, secondsi);
                            Console.WriteLine("enter the destination: ");
					  string dest = Convert.ToString(Console.ReadLine());
                            availableFlights((List<Flights>)flights, dest, calendarr);
			  break;

				case 6:
                            Console.WriteLine("enter the year of the flight: ");
                            int yearia = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("enter the month of the flight: ");
                            int monthia = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("enter the day of the flight: ");
                            int dayia = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("enter the hour of the flight: ");
                            int houria = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("enter the minutes of the flight: ");
                            int minutesia = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("enter the senconds of the flight: ");
                            int secondsia = Convert.ToInt32(Console.ReadLine());
                            DateTime calendarra = new DateTime(yearia, monthia, dayia, houria, minutesia, secondsia);
                            Console.WriteLine("enter the destination: ");
                            String desti = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("enter the depart: ");
                            String depart = Convert.ToString(Console.ReadLine());
                            Booking.availableFlights((List<Flights>)flights, desti, depart, calendarra);
                            break;
                    }
                    break;
                case 3:
                    Booking.checkForFreePlaces((List<Flights>)flights);
                    break;
                case 4:
                    Booking.bookFlight((List<Flights>)flights);
                    break;
                case 5:
                    Booking.calculatePrice((List<Flights>)flights);
                    break;
                case 6:
                    Console.WriteLine("enter the flight number: ");
                    int fn = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter the passenger id: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    int ff = 0;
                    int pp = 0;
                    foreach (Flights f in flights) {
                        
                        if ((f.FlightNumber == fn)) {
                            foreach (Passengers p in f.Passengers) {
                                if ((p.PassengerId == id)) {
                                    if ((p.VIP == true)) {
                                        Console.WriteLine("Premium Services");
                                        Console.WriteLine("Food");
                                        Console.WriteLine("....");
                                    }
                                    else {
                                        Console.WriteLine("Sorry, these services are available only for VIP passengers");
                                    }
                                    pp = 1;
                                    break;
                                }
                            }
                            ff = 1;
                            break;
                        }
                    }
                    if (ff == 0)
                    {
                        Console.WriteLine("wrong flight number");
                    }
                    if (pp == 0)
                    {
                        Console.WriteLine("wrong passengerId");
                    }
            }
        } while (true);
        
    }
    
    public static void availableFlights(List<Flights> flights) {
        if (string.ReferenceEquals(flights, null))
        {
            Console.WriteLine("no flight is available");
        }
        
        foreach (Flights flight in flights) {
            Console.WriteLine(flight.ToString());
        }
        
    }
    
    public static void availableFlights(List<Flights> flights, DateTime c) {
        if (string.ReferenceEquals(flights, null)) {
            Console.WriteLine("no flight is available");
            return;
        }
        
        foreach (Flights flight in flights) {
            if ((flight.DepartDate == c)) {
                Console.WriteLine(flight.ToString());
            }
            
        }
        
    }
    
    public static void availableFlights(List<Flights> flights, String depart, String destination) {
        if (!string.ReferenceEquals(flights, null)) {
            foreach (Flights flight in flights)
            {
                if ((flight.Depart.Equals(depart)) && flight.Destionation.Equals(destination))
                {
                    Console.WriteLine(flight.ToString());
                }

            }
            
        }
        
    }
    
    public static void availableFlights(List<Flights> flights, String depart, String destination, DateTime c) {
        if (!string.ReferenceEquals(flights, null)) {
            
            foreach (Flights flight in flights)
            {
                if ((flight.Depart.Equals(depart)) && flight.Destionation.Equals(destination) && (flight.DepartDate == (c)))
                {
                    Console.WriteLine(flight.ToString());
                }

            }

        }
        
    }
    
    public static void availableFlights(List<Flights> flights, String Destination) {
        if (!string.ReferenceEquals(flights, null)) {
            
            foreach (Flights flight in flights)
            {
                if (flight.Destionation.Equals(Destination))
                {
                    Console.WriteLine(flight.ToString());
                }

            }

        }
        
    }
    
    public static void availableFlights(List<Flights> flights, String Destination, DateTime cal) {
        if (!string.ReferenceEquals(flights, null)) {
            foreach (Flights flight in flights)
            {
                if ((flight.DepartDate== cal) && flight.Destionation.Equals(Destination))
                {
                    Console.WriteLine(flight.ToString());
                }

            }

        }
        
    }
    
    public static bool freePlace(Flights flight) {
        if ((flight.TotalNumberOfPassengers == flight.OccupiedPlaces)) {
            return false;
        }
        else {
            return true;
        }
        
    }
    
    public static void bookFlight(List<Flights> flights) {
        Booking.availableFlights(flights);
        int flightNumber = Convert.ToInt32(Console.ReadLine());
        Passengers passenger = Booking.addPassenger();
        Console.WriteLine(("Passenger id = " 
                        + (passenger.PassengerId + " added successfully")));
        if (!string.ReferenceEquals(flights, null)) {
            foreach (Flights flight in flights) {
                if ((flight.FlightNumber == flightNumber)) {
                    flightNumber = flight.FlightNumber;
                    if ((Booking.freePlace(flight) == true)) {
                        flight.addPassengers(flight.Passengers, passenger);
                        Console.WriteLine("flight booked successfully :) ");
                        int places = flight.Passengers.Count;
                        flight.OccupiedPlaces =places;
                        passenger.FlightNum = flight.FlightNumber;
                    }
                    else {
                        Console.WriteLine("flight book failed, there is no available place :( ");
                        passenger = null;
                    }
                    
                    break;
                }
                
            }
            
        }
        
    }
    
    static int i = 0;
    
    public static void addFlight(List<Flights> flights) {
        Console.WriteLine("enter the destination of the flight: ");
        String destination = Convert.ToString(Console.ReadLine());
        Console.WriteLine("enter the point depart of the flight: ");
        String depart = Convert.ToString(Console.ReadLine());
        Console.WriteLine("enter the year of the flight: ");
        int year = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the month of the flight: ");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the day of the flight: ");
        int day = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the hour of the flight: ");
        int hour = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the minutes of the flight: ");
        int minutes = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the seconds of the flight: ");
        int seconds = Convert.ToInt32(Console.ReadLine());
        DateTime calendar = new DateTime(year, month, day, hour, minutes, seconds);
        Console.WriteLine("enter the price of the flight: ");
        int prix = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the total number of the passengers: ");
        int totalNumberOfPassengers = Convert.ToInt32(Console.ReadLine());
        Flights flight = new Flights(destination, depart, calendar, prix, totalNumberOfPassengers);
        flights.Add(flight);
        Console.WriteLine("Flight added successfully");
    }
    
    public static Passengers addPassenger() {
        
        Console.WriteLine("enter the lastName of the passenger: ");
        String lastName = Convert.ToString(Console.ReadLine());
        Console.WriteLine("enter the firstName of the passenger: ");
        String fristName = Convert.ToString(Console.ReadLine());
        Console.WriteLine("enter the age of the passenger: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter the weight of passenger\'s handbag in KG");
        double kiloOfHandBag = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("enter the weight of passenger\'s checked baggages");
        double kiloOfcheckedBaggage = Convert.ToDouble(Console.ReadLine());
        Packages lug = new Packages(kiloOfHandBag, kiloOfcheckedBaggage);
        Console.WriteLine("Is the passenger a VIP?\n 1: yes\n 2: no");
        int vip = Convert.ToInt32(Console.ReadLine());
        Boolean VIP = false;
        if (((vip != 1)  && (vip != 2))) {
            Console.WriteLine("Is the passenger a VIP?\n 1: yes\n 2: no");
            vip = Convert.ToInt32(Console.ReadLine());
        }
        else if ((vip == 1)) {
            VIP = true;
        }
        
        Passengers passenger = new Passengers(lastName, fristName, age, lug, VIP);
        return passenger;
    }
    
    public static void checkForFreePlaces(List<Flights> flights) {
       
        Console.WriteLine("enter the flight number:");
        int flightNumber = Convert.ToInt32(Console.ReadLine());
        foreach (Flights flight in flights) {
            if ((flight.FlightNumber == flightNumber)) {
                int places = (flight.TotalNumberOfPassengers - flight.OccupiedPlaces);
                if ((places <= 0)) {
                    Console.WriteLine("Unfortunatly, all the places are occupied :( ");
                }
                else {
                    Console.WriteLine(("Fortunately " 
                                    + (places + " are still availables :D ")));
                }
                
                break;
            }
            
        }
        
    }
    
    public static void calculatePrice(List<Flights> flights) {
        //Passengers pas = null;
        Console.WriteLine("enter your flightNumber: ");
        int flightNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter your passengerId: ");
        int passengerId = Convert.ToInt32(Console.ReadLine());
        double price = 0; int i = 0;
        foreach (Flights f in flights) {
            if ((f.FlightNumber == flightNumber)) {
                foreach (Passengers p in f.Passengers) {
                    if ((p.PassengerId == passengerId)) {
                        price = (f.Prix + p.Packages.Price);
                        if ((p.VIP == true))
                        {
                            price *= (f.PrixReductionVIP / 100);
                        }

                        Console.WriteLine(("the total price is: " + price + " Euro"));
                        break;
                    }
                        
                }
                if(price == 0)
                {
                    Console.WriteLine("wrong passengerId or passenger not registred in tha flight: ");
                }
                i++;
                break;
                
            }
            if (i == 0)
            {
                Console.WriteLine("wrong flight number");
            }

        }
        
    }
}