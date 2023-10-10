namespace Animal;
class Cat
{
	public string color;
	public int leg;
	public bool isTailLong;
	public int weight;
	public int height;
	public void Jump(string direction)
	{
		Console.WriteLine("Jump \t" + direction);
	}
	public void Run()
	{
		Console.WriteLine("Run");
	}
}