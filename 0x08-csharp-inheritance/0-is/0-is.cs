using System;

class Obj
{
	///<summary>Checks if obj is an int</summary>
	public static bool IsOfTypeInt(object obj)
	{
		if (obj is int)
        {
			return (true);
        }
		return (false);
	}
}
