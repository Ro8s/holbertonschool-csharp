using System;

class Obj
{
	///<summary>Checks if derivedType is a sublcass of basetype</summary>
	public static bool IsOnlyASubclass(Type derivedType, Type baseType)
	{
		if (derivedType.IsSubclassOf(baseType))
        {
			return (true);
        }
		return (false);
	}
}
