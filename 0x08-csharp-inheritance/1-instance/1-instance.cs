using System;

class Obj
{
	///<summary>Checks if obj is an instance of Array</summary>
	public static bool IsInstanceOfArray(object obj)
	{
		if (obj is Array)
		{
			return (true);
		}
		return (false);
	}
}
