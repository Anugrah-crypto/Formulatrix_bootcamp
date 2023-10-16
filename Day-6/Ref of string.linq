<Query Kind="Program">
  <NuGetReference>Microsoft.Extensions.Http</NuGetReference>
  <Namespace>System.Net</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

//Ref String
void Main()
{
	string myString = "Hello";
	StringAppender(ref myString);//It's must using ref because it is immutable reference
	myString.Dump();
}

void StringAppender(ref string input)
{
	input = input + "!!!!";
}
