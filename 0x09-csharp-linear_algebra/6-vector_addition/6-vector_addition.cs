using System;

/// <summary> VectorMath Class </summary>
class VectorMath
{
	/// <summary>
	/// Method that adds two vectors
	/// </summary>
	/// <param name="vector1">First vector</param>
	/// <param name="vector2">Second vector</param>
	/// <returns>The addition between vector1 and vector2</returns>
	public static double[] Add(double[] vector1, double[] vector2)
	{
		if (vector1.Length != vector2.Length)
        {
			return (-1);
        }
		if (vector1.Length < 2 || vector1.Length > 3)
        {
			return (-1);
        }
		if (vector2.Length < 2 || vector2.Length > 3)
		{
			return (-1);
		}
		double[] res = new double[vector1.Length]
		for(int i = 0; i < vector1.Length; i++)
        {
			res[i] = vector1[i] + vector2[i];
        }
		return (res);
	}
}

