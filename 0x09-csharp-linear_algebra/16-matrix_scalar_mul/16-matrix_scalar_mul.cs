using System;

/// <summary>
/// MatrixMath class
/// </summary>
class MatrixMath
{
	/// <summary>
	/// method that multiplies a matrix and a scalar
	/// </summary>
	/// <param name="matrix">matrix to mult.</param>
	/// <param name="scalar">scalar</param>
	/// <returns>returns the resulting matrix</returns>
	public static double[,] MultiplyScalar(double[,] matrix, double scalar)
	{
		double[,] error = new double[,] { { -1 } };
		if (matrix.Length != 4 && matrix.Length != 9)
		{
			return (error);
		}
		if (matrix.GetLength(0) != matrix.GetLength(1))
		{
			return (error);
		}
		double[,] res = matrix;
		for (int i = 0; i < matrix.GetLength(0); i++)
		{
			for (int j = 0; j < matrix.GetLength(1); j++)
			{
				res[i, j] *= scalar;
			}
		}
		return (res);
	}
}
