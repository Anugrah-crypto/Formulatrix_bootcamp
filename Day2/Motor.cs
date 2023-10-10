namespace Vechiles;
using Component;
public class Motor
{
	public Engine Mesin;
	public Tire Roda;
	public Aki accu;
	public Motor(Engine engine, Tire tire, Aki aki) 
	{
		Console.WriteLine("sudah menerima engine, ban, aki");
		Mesin = engine;
		Roda = tire;
		accu = aki;
	}
	
	
	
}