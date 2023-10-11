<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//Method Hiding + Overriding
class Program 
{
	static void Main() 
	{
		Cat cat = new Cat(); //Override
		cat.MakeSound(); //Meow 
		Animal parent = cat;
		parent.MakeSound(); //Meow
		
		Dog dog = new Dog(); //Idem
		dog.MakeSound(); //Make Sound
		Animal parent2 = dog;
		parent2.MakeSound(); //Make Sound
		
		Bird bird = new Bird(); //Method Hiding
		bird.MakeSound(); //Chip
		Animal parent3 = bird;
		parent3.MakeSound(); //MakeSound
	
	}
}

class Bird : Animal
{
	public new void MakeSound() //Method Hiding
	{
		Console.WriteLine("Chip");
	}
}
class Dog : Animal //Ngikut
{ 
public virtual void MakeSound (){
Console.WriteLine("Kukuruyuk");
}

}
class Cat : Animal //Overriding
{
	public override void MakeSound()
	{
		Console.WriteLine("Meow");
	}
}
class Animal
{
	public virtual void MakeSound()
	{
		Console.WriteLine("Make Sound");
	}
}