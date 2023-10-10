namespace Pesawat;

public class Hawker : Airplane
{
	public Hawker(string name, string jenis) : base(name, jenis)
	{
		Console.WriteLine("Pesawat jenis " + jenis + " bernama " + name);
	}
	public void dorr()
	{
		Console.WriteLine("dorr");
	}
}
