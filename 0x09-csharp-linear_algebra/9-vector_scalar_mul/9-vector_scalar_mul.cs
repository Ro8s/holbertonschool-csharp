using System;

/// <summary>
/// VectorMath class
/// </summary>
class VectorMath
{
    /// <summary>
    /// Method that multiplies a vector and a scalar
    /// </summary>
    /// <param name="vector"> vector</param>
    /// <param name="scalar"> scalar</param>
    /// <returns>Multiplied vector</returns>
    public static double[] Multiply(double[] vector, double scalar)
	{
        double[] error = new double[] {-1};
        if (vector.Length != 2 && vector.Length != 3)
        {
            return (error);
        }
        double[] res = new double[vector.Length];
        for(int i = 0; i < vector.Length; i++)
        {
            res[i] = vector[i] * scalar;
        }
        return (res);
	}
}

