<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//ReadOnly
class Program {
	static void Main(){
		Car car = new Car(1000);
		car.price.Dump();
		//car.price = 3; readonly
	}
}
class Car {
	public readonly int price;
	public Car(int price) {
		this.price = price;
	}
	
	//public void SetPrice(int num) {
	//	price = num;
	//}
}