<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//Parsing with TryParse to safely parsing 
void Main()
{
	string myString = "999999999";//max int can handle.
	bool statusParsing = int.TryParse(myString, out int result);
	result.Dump();
	statusParsing.Dump();
	
}