<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//ternary operator (if else)
void Main()
{
	bool status = 10 > 0 ? true : false;
	string result = 10 > 0 ? "yes" : "no";
}

bool Checker(int a, int b) {
	return a > b;
}
string CheckerTernary(int a, int b)
{
	return a > b ? "bigger" : "smaller";
}