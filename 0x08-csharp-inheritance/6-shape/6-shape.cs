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
		set {
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
}
