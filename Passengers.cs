public class Passengers
{
	private static int id = 0;
	private static int passengerId;
	private string lastName;
	private string fristName;
	private int age;
	private Packages packages;
	private int flightNum;
	private bool VIP_Conflict;

	public Passengers() : base()
	{
	}



	public Passengers(string lastName, string fristName, int age, Packages packages, bool vIP) : base()
	{
		this.PassengerId = ++id;
		this.lastName = lastName;
		this.fristName = fristName;
		this.age = age;
		this.packages = packages;
		VIP_Conflict = vIP;
	}



	public Passengers(string lastName, string fristName, int age, Packages packages, int flightNum, bool vIP) : base()
	{
		this.PassengerId = ++id;
		this.lastName = lastName;
		this.fristName = fristName;
		this.age = age;
		this.packages = packages;
		this.flightNum = flightNum;
		VIP_Conflict = vIP;
	}

	public virtual int PassengerId
	{
		get
		{
			return passengerId;
		}
		set
		{
			Passengers.passengerId = value;
		}
	}



	public virtual string LastName
	{
		get
		{
			return lastName;
		}
		set
		{
			this.lastName = value;
		}
	}


	public virtual string FristName
	{
		get
		{
			return fristName;
		}
		set
		{
			this.fristName = value;
		}
	}


	public virtual int Age
	{
		get
		{
			return age;
		}
		set
		{
			this.age = value;
		}
	}


	public virtual Packages Packages
	{
		get
		{
			return packages;
		}
		set
		{
			this.packages = value;
		}
	}


	public virtual int FlightNum
	{
		get
		{
			return flightNum;
		}
		set
		{
			this.flightNum = value;
		}
	}


	public virtual bool VIP
	{
		get
		{
			return VIP_Conflict;
		}
		set
		{
			VIP_Conflict = value;
		}
	}


	public override string ToString()
	{
		return "Passengers [PassengerId =" + PassengerId + ", " + (!string.ReferenceEquals(LastName, null) ? "Last Name =" + LastName + ", " : "") + (!string.ReferenceEquals(FristName, null) ? "Frist Name =" + FristName + ", " : "") + "getAge =" + Age + ", " + (Packages != null ? "getPackages =" + Packages + ", " : "") + "getFlightNum =" + FlightNum + ", isVIP =" + VIP + "]";
	}

}
