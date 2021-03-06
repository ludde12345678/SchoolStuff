using System;
using System.Collections.Generic;
using System.Text;
using Maths.Matrixes;
using Maths.LinAlg.VectorRooms;

namespace Maths.LinAlg.Objects
{
    struct Vector2D
    {
        private Matrix coordinates;
        private VectorSpace2D vectorSpace;
        public Vector2D(VectorSpace2D VectorSpace, int x, int y)
        {
            vectorSpace = VectorSpace;
            coordinates = new Matrix(2, 1, new List<int> { x, y });

        }
        public Vector2D(VectorSpace2D VectorSpace, Matrix matrix)
        {
            vectorSpace = VectorSpace;
            coordinates = matrix;
        }
    }
}
