using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolStuff.Matrixes
{
    struct Matrix
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

        public Matrix Multiply(Matrix m1)
        {
            if(m1.rows == colums)
            {
                Matrix returnMatrix = new Matrix(rows, m1.colums);
                for (int m1colum = 0; m1colum < m1.colums; m1colum++)
                {
                    for (int mcolums = 0; mcolums < colums; mcolums++)
                    {
                        int sum = 0;
                        for (int m1rows = 0; m1rows < m1.rows; m1rows++)
                        {
                            sum += GetVal(mcolums, m1rows) * m1.GetVal(m1rows, m1colum);
                        }
                        returnMatrix.InsertAt(sum, mcolums, m1colum);
                    }
                }
                return returnMatrix;
            }
            return new Matrix(3, 3);
        }
        public override string ToString()
        {
            string returnstring = "[ ";
            foreach (var i in matrix)
            {
                foreach (var e in i)
                {
                    returnstring += e + ", ";
                }
                returnstring += "\n  ";
            }
            returnstring += "]";
            return returnstring;
        }
    }
}
