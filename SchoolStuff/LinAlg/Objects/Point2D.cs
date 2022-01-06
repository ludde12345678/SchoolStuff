using Maths.LinAlg.VectorRooms;
using Maths.Matrixes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maths.LinAlg.Objects
{
    struct Point2D
    {
        private Matrix coordinates;
        private VectorSpace2D vectorSpace;

        public Point2D(VectorSpace2D VectorSpace, int x, int y)
        {
            vectorSpace = VectorSpace;
            coordinates = new Matrix(2, 1, new List<int> { x, y });
        }
        public Point2D(VectorSpace2D VectorSpace, Matrix matrix)
        {
            vectorSpace = VectorSpace;
            coordinates = matrix;
        }

    }
}
