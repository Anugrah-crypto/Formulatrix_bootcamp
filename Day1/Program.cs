// See https://aka.ms/new-console-template for more information
using Animal;
using Vehicles;
Cat Black=new Cat();
Car Toyota = new Car();
string Engine= Toyota.EngineRun (true);
Console.WriteLine(Engine);
Black.color= "Black";
Black.leg=5;
Black.isTailLong=true;
Black.weight=200;
Black.height=2;
Console.WriteLine(Black.color);
Black.Jump("Left");
