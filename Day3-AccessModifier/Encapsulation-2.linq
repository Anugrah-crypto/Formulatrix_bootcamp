<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//Property
class Program {
	static void Main() {
		Car car = new Car(9);
		Console.WriteLine(car.Age);
		//car.Age = 8 //Set Accessor is Private
		
		car.Balance = 10;
		int x = car.Balance;
		x.Dump();
	}
}

class Car {
	//public int age; 
	//variable
	public int Age {get; private set;} //property
	private int _balance;
	public int Balance
	{
		get
		{
			return _balance * 1000;
		}
		set
		{
			if(value > 0) {
				_balance = value;
			}
		}
	}
	
	private string _name;
	public Car(int age) {
		Age = age;
	}
	
	
}