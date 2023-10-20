<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//Reference Type, why dont need Ref
void Main() {
//    Console.WriteLine("Input the price");
//	string input=Console.ReadLine();
//	int.TryParse(input, out int result);
//	 
int result= 2000;
	
	Car car = new Car(result); //Reference Type
	MultiplyByTwoCar(car);
	car.Dump(); // 4000
}

void MultiplyByTwoCar(Car input)
{
	input.price = input.price * 2;
}

class Car {
	public int price;
	public Car(int value)
	{
		price = value;
	}
}
