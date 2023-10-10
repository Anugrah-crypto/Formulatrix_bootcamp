namespace Vehicles;
class Car
{
	public int tires;
	public string colour;
	public int door;
	public string EngineRun(bool status)
	{
		if(status)
		{
			return "Engine Running";
		}
		else
		{
			return "Engine Not Running";
		}
	}
}