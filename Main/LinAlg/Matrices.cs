using System;
namespace LinAlg
{
	partial class MainClass
	{
		public static Matrix createMat(int col, int row)
		{
			System.Diagnostics.Debug.Assert(col > 0 && row > 0);
			Matrix mat = new Matrix();
			mat.cols = col;
			mat.rows = row;
			mat.colVecs = new Vector[mat.cols];
			//Initialize column vector array first
			for (int i = 0; i < mat.cols; i++)
			{
				Console.WriteLine("Enter the values for column {0}", i + 1);
				mat.colVecs[i] = createVec(mat.rows);

			}
			//Translate the colvec array to the vars array
			mat.vars = new double[row, col];
			for (int i = 0; i < mat.rows; i++)
			{
				for (int j = 0; j < mat.cols; j++)
				{
					mat.vars[i, j] = mat.colVecs[j].vars[i];
				}
			}
			return mat;
		}

		public static void printMat(Matrix mat)
		{
			System.Diagnostics.Debug.Assert(mat.rows > 0 && mat.cols > 0);
			for (int i = 0; i < mat.rows; i++)
			{
				Console.Write("|");
				for (int j = 0; j < mat.cols; j++)
				{
					Console.Write("{0}", mat.vars[i, j]);
					if (j != mat.cols - 1)
					{
						Console.Write("    ");
					}
 				}
				Console.WriteLine("|");
			}

		}

		public static Matrix addMat(Matrix mat1, Matrix mat2)
		{
			System.Diagnostics.Debug.Assert(mat1.cols == mat2.cols && mat2.rows == mat1.rows);
			Matrix mat3 = new Matrix();
			mat3.rows = mat1.rows;
			mat3.cols = mat1.cols;
			mat3.colVecs = new Vector[mat3.cols];
			for (int i = 0; i < mat3.cols; i++)
			{
				mat3.colVecs[i] = vectorAdd(mat1.colVecs[i], mat2.colVecs[i]);
			}

			mat3.vars = new double[mat3.rows, mat3.cols];
			for (int i = 0; i < mat3.rows; i++)
			{
				for (int j = 0; j < mat3.cols; j++)
				{
					mat3.vars[i, j] = mat3.colVecs[j].vars[i];
				}
			}
			return mat3;

		}

	}

}
