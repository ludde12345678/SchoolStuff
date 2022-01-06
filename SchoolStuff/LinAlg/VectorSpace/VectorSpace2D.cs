using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using Maths.Matrixes;

namespace Maths.LinAlg.VectorRooms
{
    struct VectorSpace2D : IEquatable<VectorSpace2D>
    {
        private Matrix orgin;
        public List<Matrix>baseVectors;
        public VectorSpace2D(Matrix e1, Matrix e2)
        {
            orgin = new Matrix(2, 1, new List<int>() { 0, 0 });
            baseVectors = new List<Matrix>() { e1, e2 };
        }

        public override int GetHashCode()
        {

        }

        public bool Equals([AllowNull] VectorSpace2D other)
        {
            throw new NotImplementedException();
        }
    }
}
