// See https://aka.ms/new-console-template for more information
using Vechiles;
using Animal;
using Component;
using System.Linq.Expressions;
class Program
{
	static void Main()
	{
		Engine Diesel= new Engine("Diesel", 5000);
		Tire Ban= new Tire("Michelin", 30);
		Aki accumul= new Aki("Kering", "Yuasa");
		Motor SupraX= new Motor(Diesel, Ban, accumul);
		Fish Rudi = new Fish();
		Airplane Garuda = new Airplane(/*Params Constructor*/25, "Jet", 6);
		Rudi.Swim();
		string condition = Garuda.Engine(true);
		Console.WriteLine(condition);
		Airplane Lion = new Airplane(69, "Propeller", 7);
		Console.WriteLine(Lion.jenis);
		Diesel.Gerak();

	}
}
