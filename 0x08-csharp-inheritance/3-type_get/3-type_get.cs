using System;
using System.Reflection;
using System.Collections.Generic;

class Obj
{
	///<summary>method that prints the names of the available properties and methods of myObj</summary>
	public static void Print(object myObj)
	{
		Console.WriteLine(myObj.GetType().Name + " Properties:");
		PropertyInfo[] mypropinfo;
		mypropinfo = myObj.GetType().GetProperties();
		for (int i = 0; i < mypropinfo.Length; i++)
        {
			Console.WriteLine(mypropinfo[i].Name);
        }
		Console.WriteLine(myObj.GetType().Name + " Methods:");
		MethodInfo[] mymethodinfo;
		mymethodinfo = myObj.GetType().GetMethods();
		for (int i = 0; i < mymethodinfo.Length; i++)
		{
			Console.WriteLine(mymethodinfo[i].Name);
		}
	}
}
