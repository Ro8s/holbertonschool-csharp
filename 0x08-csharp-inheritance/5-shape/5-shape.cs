using System;

class Shape
{
	/// <summary> method that throw a NotImplementedException </summary>
	public virtual int Area()
	{
		throw new NotImplementedException("Area() is not implemented");
	}
}
