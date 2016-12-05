using System;
namespace LinAlg
{
	
	public struct Matrix
	{
		public double[,] vars;
		public int rows;
		public int cols;
		public Vector[] colVecs;
	}
	public struct Vector
	{
		public double[] vars;
		public int size;
	}
}
