using System;

class VectorMath
{
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
