namespace Component;

public class Engine
{
	public string brand;
	public int sizes;
	public Engine (string merek, int ukuran)
	{
		brand=merek;
		sizes=ukuran;
	}
	public void Gerak ()
	{
		Console.WriteLine("Motor bergerak menggunakan Mesin "+ sizes + "dengan merek "+ brand);
	}
}
