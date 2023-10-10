namespace Pesawat;

public class Cessna:Airplane
{
	public Cessna(string name, string jenis):base(name, jenis)
	{
		Console.WriteLine("Pesawat jenis "+ jenis + " bernama "+ name);
	}
	public void vroom()
	{
		Console.WriteLine("vroomm");
	}
}
