// See https://aka.ms/new-console-template for more information
using Day2_Inheretance;
using Pesawat;
class Program
{
	static void Main()
	{
		Airbus F001= new Airbus("Si Jalak", "Jet");
		F001.fly();
		F001.sound();
		Cessna T405= new Cessna("Elang", "Propeller");
		T405.fly();
		
	}
}
