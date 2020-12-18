using System;
using System.Collections.Generic;

public class Flights
{

	private static int count = 0;
	private int flightNumber;

	private string Destionation_Conflict;

	private string Depart_Conflict;
	private int totalNumberOfPassengers;
	private int prix;
	private double prixReductionVIP = 0.25;
	private DateTime dateDepart;
	private int occupiedPlaces = 0;
	private IList<Passengers> passengers = new List<Passengers>();


	public Flights() : base()
	{
	}

	public Flights(string destionation, string depart, int prix, int totalNumberOfPassengers) : base()
	{
		this.FlightNumber = ++count;
		Destionation_Conflict = destionation;
		Depart_Conflict = depart;
		this.prix = prix;
		this.totalNumberOfPassengers = totalNumberOfPassengers;
	}

	public Flights(string destionation, string depart, DateTime departDate, int prix, int totalNumberOfPassengers) : base()
	{
		this.FlightNumber = ++count;
		this.Destionation_Conflict = destionation;
		this.Depart_Conflict = depart;
		this.dateDepart = departDate;
		this.prix = prix;
		this.totalNumberOfPassengers = totalNumberOfPassengers;
	}

	public Flights(string destionation, string depart, int prix, int totalNumberOfPassengers, IList<Passengers> passengers) : base()
	{
		this.FlightNumber = ++count;
		Destionation_Conflict = destionation;
		Depart_Conflict = depart;
		this.prix = prix;
		this.totalNumberOfPassengers = totalNumberOfPassengers;
		this.passengers = passengers;
	}

	public Flights(string destionation, string depart, DateTime departDate, int prix, int totalNumberOfPassengers, IList<Passengers> passengers) : base()
	{
		this.FlightNumber = ++count;
		this.Destionation_Conflict = destionation;
		this.Depart_Conflict = depart;
		this.dateDepart = departDate;
		this.prix = prix;
		this.totalNumberOfPassengers = totalNumberOfPassengers;
		this.passengers = passengers;
	}


	public virtual int FlightNumber
	{
		get
		{
			return this.flightNumber;
		}
		set
		{
			this.flightNumber = value;
		}
	}




	public virtual string Destionation
	{
		get
		{
			return Destionation_Conflict;
		}
		set
		{
			Destionation_Conflict = value;
		}
	}




	public virtual string Depart
	{
		get
		{
			return Depart_Conflict;
		}
		set
		{
			Depart_Conflict = value;
		}
	}



	public virtual DateTime DepartDate
	{
		get
		{
			return this.dateDepart;
		}
		set
		{
			this.dateDepart = value;
		}
	}



	public virtual int TotalNumberOfPassengers
	{
		get
		{
			return this.totalNumberOfPassengers;
		}
		set
		{
			this.totalNumberOfPassengers = value;
		}
	}




	public virtual int Prix
	{
		get
		{
			return prix;
		}
		set
		{
			this.prix = value;
		}
	}




	public virtual double PrixReductionVIP
	{
		get
		{
			return prixReductionVIP;
		}
		set
		{
			this.prixReductionVIP = value;
		}
	}




	public virtual int OccupiedPlaces
	{
		get
		{
			if (this.passengers.Count == 0)
			{
				return 0;
			}
			this.occupiedPlaces = this.passengers.Count;
			return this.occupiedPlaces;
		}
		set
		{
			this.occupiedPlaces = value;
		}
	}




	public virtual IList<Passengers> Passengers
	{
		get
		{
			return passengers;
		}
		set
		{
			this.passengers = value;
		}
	}




	public virtual void addPassengers(IList<Passengers> passengers, Passengers passenger)
	{
		this.passengers.Add(passenger);
	}

	

	public override string ToString()
	{
		return "Flight [Flight Number =" + flightNumber + ", " + (!string.ReferenceEquals(Destionation, null) ? "Destionation =" + Destionation + ", " : "") + (!string.ReferenceEquals(Depart, null) ? "Depart =" + Depart + ", " : "") + (dateDepart != null ? "DepartDate =" + dateDepart + ", " : "") + "Total Number Of Passengers = =" + totalNumberOfPassengers + ", Prix =" + prix + " , Prix Reduction VIP = " + prixReductionVIP + ", Occupied Places =" + occupiedPlaces +
		 (!string.ReferenceEquals(passengers, null) ? "Passengers =" + Passengers.ToString() + ","  : "") + "]";
	}

}