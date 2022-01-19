using System;

/// <summary>
/// MatrixMath class
/// </summary>
class MatrixMath
{
	/// <summary>
	/// method that rotates a square 2D matrix by a given angle in radians
	/// </summary>
	/// <param name="matrix">matrix</param>
	/// <param name="angle">angle</param>
	/// <returns>resulting matrix</returns>
	public static double[,] Rotate2D(double[,] matrix, double angle)
	{
		double[,] error = new double[,] { { -1 } };
		if (matrix.GetLength(0) != matrix.GetLength(1))
		{
			return (error);
		}
		double[,] rotation = new double[2,2] { { Math.Cos(angle), Math.Sin(angle)}, { (-1) * Math.Sin(angle), Math.Cos(angle)} };
		double[,] res = new double[matrix.GetLength(0), matrix.GetLength(1)];
		double op = 0;
		for (int i = 0; i < matrix.GetLength(0); i++)
		{
			for (int j = 0; j < rotation.GetLength(1); j++)
			{
				op = 0;
				for (int k = 0; k < matrix.GetLength(1); k++)
				{
					op += matrix[i, k] * rotation[k, j];
				}
				res[i, j] = Math.Round(op);
			}
		}
		return (res);
	}
}
