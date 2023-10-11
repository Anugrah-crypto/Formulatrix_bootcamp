<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//Overloading
class Program {
	static void Main() {
		Calculator calc = new();
		calc.Add();
		calc.Add(7,4);
		calc.Add(3,4,5);
		calc.Add(1,8,6,5);
		calc.Add("1","2").Dump();
	}
}
class Calculator {
	public void Add() {
		"None".Dump();
	}
	public void Add(int a, int b) {
		Console.WriteLine(a+b);
	}
	public void Add(int a, int b, int c) {
		Console.WriteLine(a+b+c);
	}
	public string Add(string a, string b) {
		return a+b;
	}
	public void Add(int a, int b, int c, int d){
		Console.WriteLine(a+b+c+d);
	}
}