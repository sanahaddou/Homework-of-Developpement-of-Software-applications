using System;

public class Packages
{

	private double kilo_HandBag = 10;
	private double kilo_CheckedBaggages = 30;
	private double price = 10;

	public Packages() : base()
	{
	}

	public Packages(double kilo_HandBag, double kilo_CheckedBaggages) : base()
	{
		if (kilo_HandBag > 10)
		{
			Console.WriteLine("kilo of handbag baggages more than the allowed kilos (10 kg)");
			return;
		}
		this.kilo_HandBag = kilo_HandBag;
		this.kilo_CheckedBaggages = kilo_CheckedBaggages;
	}

	public virtual double Kilo_HandBag
	{
		get
		{
			return kilo_HandBag;
		}
		set
		{
			this.kilo_HandBag = value;
		}
	}


	public virtual double Kilo_CheckedBaggages
	{
		get
		{
			return kilo_CheckedBaggages;
		}
		set
		{
			this.kilo_CheckedBaggages = value;
		}
	}


	public virtual double Price
	{
		get
		{
			if (this.Kilo_CheckedBaggages > 30)
			{
				this.price = (this.Kilo_CheckedBaggages - 30) * (this.price);
			}
			return price;
		}
		set
		{
			this.price = value;
		}
	}


	public override string ToString()
	{
		return "Packages [Kilo_HandBag =" + Kilo_HandBag + ", Kilo_CheckedBaggages =" + Kilo_CheckedBaggages + ", Price =" + Price + "]";
	}


}
