using System;
using System.Collections.Generic;
using System.Text;

namespace Maths.Matrix
{
    class Matrix
    {
        private int rows;
        private int colums;
        private List<List<int>> matrix;
        public Matrix(int rows, int colums)
        {
            this.colums = colums;
            this.rows = rows;
            matrix = new List<List<int>>();
            for (int i = 0; i < rows; i++)
            {
                List<int> templist = new List<int>();
                for (int e = 0; e < colums; e++)
                {
                    templist.Add(0);
                }
                matrix.Add(templist);
            }
        }
        public Matrix(int rows, int colums, List<int> elements)
        {
            this.colums = colums;
            this.rows = rows;
            matrix = new List<List<int>>();
            for (int i = 0; i < rows; i++)
            {
                List<int> templist = new List<int>();
                for (int e = 0; e < colums; e++)
                {
                    templist.Add(0);
                }
                matrix.Add(templist);
            }
            for (int i = 0; i < rows; i++)
            {
                for (int e = 0; e < colums; e++)
                {
                    matrix[i][e] = elements[0];
                    elements.RemoveAt(0);
                }
            }
        }
        public int InsertAt(int val, int row, int colum)
        {
            matrix[row][colum] = val;
            return val;
        }
        public int GetVal(int row, int colum)
        {
            return matrix[row][colum];
        }
        public static Matrix operator +(Matrix a, int b)
        {
            Matrix returnmatrix = new Matrix(a.rows, a.colums);
            for (int i = 0; i < a.rows; i++)
            {
                for (int e = 0; e < a.colums; e++)
                {
                    returnmatrix.InsertAt(a.GetVal(i,e) + b, i, e);
                }
            }
            return returnmatrix;
        }
        public static Matrix operator -(Matrix a, int b)
        {
            Matrix returnmatrix = new Matrix(a.rows, a.colums);
            for (int i = 0; i < a.rows; i++)
            {
                for (int e = 0; e < a.colums; e++)
                {
                    returnmatrix.InsertAt(a.GetVal(i, e) - b, i, e);
                }
            }
            return returnmatrix;
        }
        public static Matrix operator *(Matrix a, int b)
        {
            Matrix returnmatrix = new Matrix(a.rows, a.colums);
            for (int i = 0; i < a.rows; i++)
            {
                for (int e = 0; e < a.colums; e++)
                {
                    returnmatrix.InsertAt(a.GetVal(i, e) * b, i, e);
                }
            }
            return returnmatrix;
        }

        public static Matrix operator *(Matrix m0, Matrix m1)
        {
            if(m1.rows == m0.colums)
            {
                Matrix returnMatrix = new Matrix(m0.rows, m1.colums);
                for (int m1colum = 0; m1colum < m1.colums; m1colum++)
                {
                    for (int mcolums = 0; mcolums < m0.colums; mcolums++)
                    {
                        int sum = 0;
                        for (int m1rows = 0; m1rows < m1.rows; m1rows++)
                        {
                            sum += m0.GetVal(mcolums, m1rows) * m1.GetVal(m1rows, m1colum);
                        }
                        returnMatrix.InsertAt(sum, mcolums, m1colum);
                    }
                }
                return returnMatrix;
            }
            return new Matrix(3, 3);
        }
        public int CalcDeterminant()
        {
            if(rows == colums)
            {
                LUdecomposition();
            }
            return 0;
        }

        private readonly void LUdecomposition()
        {
            int sum = 0;
            for (int i = 0; i < colums; i++)
            {
                // gauss elimination bby
                int v1 = matrix[i][i];
                for (int e = i + 1; e < colums; e++)
                {

                }
            }
        }

        public Matrix Identity3()
        {
            return new Matrix(3, 3, new List<int>()
            {1,0,0,
             0,1,0,
             0,0,1});
        }
        public Matrix Identity2()
        {
            return new Matrix(2, 2, new List<int>()
            {1,0,
             0,1});
        }
        public override string ToString()
        {
            string returnstring = "[";
            foreach (var i in matrix)
            {
                foreach (var e in i)
                {
                    returnstring += e + ", ";
                }
                returnstring += "\n ";
            }
            returnstring = returnstring.TrimEnd(' ', '\n', ',');
            returnstring += "]\n";
            return returnstring;
        }
        public override int GetHashCode()
        {
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int e = 0; e < colums; e++)
                {
                    sum += matrix[i][e]
                }
            }
        }
    }
}
