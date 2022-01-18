using System;

/// <summary>
/// MatrixMath class
/// </summary>
class MatrixMath
{
	/// <summary>
    /// method that multiplies two matrix
    /// </summary>
    /// <param name="matrix1">first matrix</param>
    /// <param name="matrix2">second matrix</param>
    /// <returns>the result of mult.</returns>
	public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
	{
		double[,] error = new double[,] { { -1 } };
		if (matrix1.GetLength(1) != matrix2.GetLength(0))
		{
			return (error);
		}
		double[,] res = new double[matrix1.GetLength(0), matrix2.GetLength(1)];
		double op = 0;
		for (int i = 0; i < matrix1.GetLength(0); i++)
        {
			for (int j = 0; j < matrix2.GetLength(1); j++)
			{
				op = 0;
				for (int k = 0; k < matrix1.GetLength(1); k++)
                {
					op += matrix1[i, k] * matrix2[j, k]; 
                }
				res[i, j] = op;
            }
        }
		return (res);
	}
}
