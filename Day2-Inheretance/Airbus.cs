using Pesawat;

namespace Day2_Inheretance;
//Child Class
public class Airbus : Airplane
{
	public Airbus(string name, string jenis) : base(name, jenis)//Parent Params
	{
		Console.WriteLine("Pesawat jenis " + jenis + " bernama " + name);
	}
	public void sound()
	{
		Console.WriteLine("Buzzz");
	}
}
