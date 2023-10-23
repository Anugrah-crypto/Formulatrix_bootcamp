<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//Override Equals from Object and As-Is
void Main() {
	//Car cara = new Car(3);
	//Car carb = cara;
	//bool result = cara == carb;
	//result.Dump();

	Car cara = new Car(3);
	Car carb = new Car(8);
	Yusuf y = new Yusuf();
	bool result = cara.Equals(y);
	result.Dump();
}
class Yusuf {}
class Car {
	public int CarId {get; private set;}
	public Car(int id) {
		CarId = id;
	}
	public override bool Equals(object e) {
		if(e is Car y)//Compare type 
		{
			var car = e as Car;//Pattern Matching
			return CarId == car.CarId;
		}
		return false;
	}
	
}