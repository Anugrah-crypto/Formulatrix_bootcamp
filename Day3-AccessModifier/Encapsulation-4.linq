<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//private
class Program {
	static void Main() {
		Cat cat = new Cat("oyen" , 4);
		cat.name.Dump();
		Console.WriteLine(cat.name);
		cat.GetAge("pass").Dump();
		
		Console.WriteLine(cat.GetAge("pass"));
		cat.SetAge(5);
		cat.GetAge("pass").Dump();
	}
}

class Cat
{
	public string name; //* //Forbidden 
	private int _catAge; //private variable _ //ownself
	
	public Cat(string name, int age) //Constructor
	{
		this.name = name;
		_catAge = age;
	}
	
	public int GetAge(string password) 
	{
		if (password == "pass")
		{
			return _catAge;
		}
		else
		{
			return 0;
		}
	}
	public void SetAge(int age)
	{
		if (age > 0)
		{
			_catAge = age;
		} 
	}
	
	public void Jump()
	{
		"Jump".Dump();
	}
	protected void Eat() //child
	{
		"Eat".Dump();
	}
}