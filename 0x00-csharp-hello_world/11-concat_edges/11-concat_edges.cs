﻿using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "C# (pronounced \"See Sharp\") is a simple, modern, object-oriented, and type-safe programming language. C# has its roots in the C family of languages and will be immediately familiar to C, C++, Java, and JavaScript programmers.";
        str = str.Substring(str.IndexOf("object-oriented"), 15) + str.Substring(str.IndexOf(" "), 1) + str.Substring(str.IndexOf("programming"), 11) + str.Substring(str.IndexOf(" "), 1) + str.Substring(str.IndexOf("in"), 2)+ str.Substring(str.IndexOf(" "), 1) + str.Substring(0,2);
		Console.WriteLine(str);
        }
}
