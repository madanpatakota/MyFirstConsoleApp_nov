
using System;

class StringMoreConcepts
{
	static void Main()
	{

		string myProjectPath = "D:\\Csharp_Nov\\MyFirstConsoleApp";

		//Members ---> Family   f , m , b , s , gf , gm
		//myProjectPath.Length

		string name1 = "john";   //4
		int lengt = name1.Length;             //4
		Console.WriteLine(lengt); //4

		string name2 = "john";
		string uName2  = name2.ToUpper(); // "JOHN"  // ?? what could be return data type ??
		Console.WriteLine(uName2);

		string name3 = "JohN";
		string uName3 = name3.ToLower(); // "john"  // ?? what could be return data type ??
		Console.WriteLine(uName3);



	}
}

