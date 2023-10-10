namespace Vechiles;

public class Airplane
{
	public int seats; //Variable
	public string jenis;
	public int tires;
	public Airplane(int seats, string jenis, int tires )//Constructor
	{
		this.seats= seats;
		this.jenis=jenis;
		this.tires=tires;
	}
	public string Engine(bool status)
	{
		if (status)
		{
			return "Flying";
		}
		else
		{
			return "InLand";
		}
	}
	public void Tire(string jumlah)//Method
	{
		Console.WriteLine(/*String Interpolation*/"The Airplane has "+ jumlah + " Tires");
	}
	
}
