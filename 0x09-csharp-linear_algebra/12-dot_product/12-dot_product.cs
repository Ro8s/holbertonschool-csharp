using System;
/// <summary>
/// VectorMath method
/// </summary>
class VectorMath
{
	/// <summary>
	/// Method that calculates dot product of either two 2D or two 3D vectors.
	/// </summary>
	/// <param name="vector1">2D or 3D vector</param>
	/// <param name="vector2">2D or 3D vector</param>
	/// <returns>Dot product between vector1 and vector2</returns>
	public static double DotProduct(double[] vector1, double[] vector2)
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
		double res = 0;
		double op;
		for (int i = 0; i < vector1.Length; i++)
        {
			op = vector1[i] * vector2[i];
			res += op;
        }
		return (res);
	}
}
