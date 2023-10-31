using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    internal class Vector
    {

        public float X { get; }
        public float Y { get; }

        public Vector(float x, float y)
        {
            X = x;
            Y = y;
        }

        public static Vector operator +(Vector left, Vector right) => new Vector(left.X + right.X, left.Y + right.Y);

        public static Vector operator -(Vector left, Vector right) => new Vector(left.X + right.X, left.Y + right.Y);

        public static Vector operator *(Vector vec, float factor) => new Vector(factor * vec.X, factor * vec.Y);

        public static Vector operator *(float factor, Vector vec) => new Vector(vec.X * factor, vec.Y * factor);

        public static Vector operator /(Vector vec, float factor) => new Vector(vec.X / factor, vec.Y / factor);

        public static bool operator ==  (Vector left, Vector right) => left.Equals(right);
        public static bool operator != (Vector left,Vector right) => !left.Equals(right);

        public override bool Equals(object obj) => obj is Vector that && this.X == that.X && this.X == that.Y;

        public override int GetHashCode() => HashCode.Combine(X,Y);  //X.GetHashCode() + Y.GetHashCode();






    }
}
