using System;

namespace LinAlg
{
	partial class MainClass
	{

		public static Vector createVec(int n)
		{
			System.Diagnostics.Debug.Assert(n > 0);
			Vector vec = new Vector();
			vec.size = n;
			vec.vars = new double[vec.size];
			//Console.WriteLine("Enter the values of the vector:");
			for (int i = 0; i < vec.size; i++)
			{
				vec.vars[i] = Convert.ToDouble(Console.ReadLine());
			}
			return vec;

		}

		public static Vector vectorAdd(Vector v1, Vector v2)
		{
			System.Diagnostics.Debug.Assert(v1.size == v2.size);
			Vector vec = new Vector();
			vec.size = v1.size;
			vec.vars = new double[vec.size];
			for (int i = 0; i < vec.size; i++)
			{
				vec.vars[i] = v1.vars[i] + v2.vars[i];
			}

			return vec;
		}
		public static Vector crossProd(Vector v1, Vector v2)
		{
			System.Diagnostics.Debug.Assert(v1.size == 3 && v2.size == 3);
			Vector vec = new Vector();
			vec.size = 3;
			vec.vars = new double[3];
			vec.vars[0] = (v1.vars[1] * v2.vars[2]) - (v1.vars[2] * v2.vars[1]);
			vec.vars[1] = (v1.vars[2] * v2.vars[0]) - (v1.vars[0] * v2.vars[2]);
			vec.vars[2] = (v1.vars[0] * v2.vars[1]) - (v1.vars[1] * v2.vars[0]);
			return vec;
		}
		public static double dotProd(Vector v1, Vector v2)
		{
			System.Diagnostics.Debug.Assert(v1.size == v2.size);
			Vector vec = new Vector();
			vec.size = v1.size;
			vec.vars = new double[vec.size];
			double dot = 0.0;
			for (int i = 0; i < vec.size; i++)
			{
				dot += (v1.vars[i] * v2.vars[i]);
			}
			return dot;
		}
		public static void printVector(Vector vec)
		{
			Console.Write("[");
			for (int i = 0; i < vec.size; i++)
			{
				Console.Write("{0}", vec.vars[i]);
				if (i != vec.size - 1)
				{
					Console.Write(", ");
				}
			}
			Console.WriteLine("]");
		}


	}
}
