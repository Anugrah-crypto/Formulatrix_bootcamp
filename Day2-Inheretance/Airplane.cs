namespace Pesawat;

public class Airplane
{
	public string jenis;
	public string name;
	public void fly()
	{
		Console.WriteLine("Terbang");
	}
	public Airplane(string jenis, string name)
	{
		Console.WriteLine("Jenis dan nama sudah diterima");
		this.jenis=jenis;
		this.name=name;
	}
	
}
