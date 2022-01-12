using System;

/// <summary> VectorMath Class </summary>
class VectorMath
{
	/// <summary>
	/// Mehtod that gives the magnitue of a vector
	/// </summary>
	/// <param name="vector">2D or 3D vector</param>
	/// <returns>Length of a vector</returns>
	public static double Magnitude(double[] vector)
	{
		if (vector.Length < 2 || vector.Length > 3)
        {
			return (-1);
        }
		double res = 0;
		double op;
		foreach (double val in vector)
        {
			op = val * val;
			res = res + op;
        }
		return (Math.Round(Math.Sqrt(res), 2);
	}
}
