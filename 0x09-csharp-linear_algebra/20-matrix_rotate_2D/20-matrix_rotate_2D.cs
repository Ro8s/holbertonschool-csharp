using System;

class MatrixMath
{
	public static double[,] Rotate2D(double[,] matrix, double angle)
	{
		double[,] error = new double[,] { { -1 } };
		if (matrix.Length != 4)
		{
			return (error);
		}
		if (matrix.GetLength(0) != matrix.GetLength(1))
		{
			return (error);
		}
		double[,] rotation = new double[,] { { Math.Cos(angle), Math.Sin(angle)}, { Math.Sin(angle), Math.Cos(angle)} };
		if (angle < 0)
        {
			rotation[2, 1] *= -1;
        }
        else
        {
			rotation[1, 2] *= -1;
        }
		double[,] res = new double[matrix.GetLength(0), rotation.GetLength(1)];
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
				res[i, j] = op;
			}
		}
		return (res);
	}
}
