using System;

/// <summary>
/// VectorMath class
/// </summary>
class VectorMath
{
	/// <summary>
	/// method that gives the magnitue of a vector
	/// </summary>
	/// <param name="vector">2D or 3D vector</param>
	/// <returns>Length of a vector</returns>
	public static double Magnitude(double[] vector)
	{
		if (vector.Length != 2 && vector.Length != 3)
        {
			return (-1);
        }
		double op = 0;
		double res = 0;
		foreach (var elem in vector)
        {
			op = elem * elem;
			res += res + op;
        }
		return (Math.Round(Math.Sqrt(res),2));
	}
}
