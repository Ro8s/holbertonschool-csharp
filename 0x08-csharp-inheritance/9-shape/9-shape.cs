using System;


class Shape
{
	/// <summary> method that throw a NotImplementedException </summary>
	public virtual int Area()
	{
		throw new NotImplementedException("Area() is not implemented");
	}
}

class Rectangle : Shape
{
	///<summary>width field</summary>
	private int width;

	///<summary>height field</summary>
	private int height;

	///<summary>Gets or sets the width.</summary>
	public int Width
	{
		get { return (width); }
		set
		{
			if (value < 0)
			{
				throw new ArgumentException("Width must be greater than or equal to 0");
			}
			else
			{
				width = value;
			}
		}
	}
	///<summary>Gets or sets the Height.</summary>
	public int Height
	{
		get { return (height); }
		set
		{
			if (value < 0)
			{
				throw new ArgumentException("Height must be greater than or equal to 0");

			}
			else
			{
				height = value;
			}
		}
	}
	/// <summary> method that returns the area</summary>
	public new int Area()
	{
		return (width * height);
	}
	/// <summary> override toString method </summary>
	public override string ToString()
	{
		return "[Rectangle] " + width + " / " + height;

	}
}

class Square : Rectangle
{
	///<summary>size field</summary>
	private int size;

	///<summary>Gets or sets the Size.</summary>
	public int Size
	{
		get { return (size); }
		set
		{
			if (value < 0)
			{
				throw new ArgumentException("Size must be greater than or equal to 0");
			}
			else
			{
				Height = value;
				Width = value;
				size = value;
			}
		}
	}
	/// <summary> override toString method </summary>
	public override string ToString()
    {
		return "[Square] " + size + " / " + size;

	}
}
