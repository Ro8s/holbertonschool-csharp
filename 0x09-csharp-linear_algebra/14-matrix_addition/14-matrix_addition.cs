using System;

/// <summary>
/// MatrixMath class
/// </summary>
class MatrixMath
{
	/// <summary>
	/// method that adds two matrix
	/// </summary>
	/// <param name="matrix1">First matrix to add</param>
	/// <param name="matrix2">Second matrix to add</param>
	/// <returns>The sum between matrix1 and matrix2</returns>
	public static double[,] Add(double[,] matrix1, double[,] matrix2)
	{
		double[,] error = new double[,] { { -1 } };
		if (matrix1.Length != matrix2.Length)
		{
			return (error);
		}
		if (matrix1.Length != 4 && matrix1.Length != 9)
		{
			return (error);
		}
		else if (matrix1.GetLength(0) != matrix1.GetLength(1))
        {
			return (error);
        }
		if (matrix2.Length != 4 && matrix2.Length != 9)
		{
			return (error);
		}
		else if (matrix2.GetLength(0) != matrix2.GetLength(1))
        {
			return (error);
        }
		double[,] res = matrix1;
		for (int i = 0; i < matrix1.Rank; i++)
        {
			for (int j = 0; j < matrix1.GetLength(i); j++)
            {
				res[i, j] += matrix2[i, j];
            }
        }
		return (res);
	}
}
