using System;

namespace COILibraryPoint
{
    public abstract class Point<T> : Object where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    { }

    public class Point1D<T> : Point<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        private readonly T x;
        public T X => x;
        public Point1D(T x)
        {
            this.x = x;
        }

        /// <summary>
        /// overrided method string for this class
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return $"({X})";
        }
    }

    public class Point2D<T> : Point1D<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        private readonly T y;
        public T Y => y;
        public Point2D(T x, T y) : base(x)
        {
            this.y = y;
        }

        /// <summary>
        /// overrided method string for this class
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return $"({X}; {Y})";
        }
    }
    public class Point3D<T> : Point2D<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        private readonly T z;
        public T Z => z;
        public Point3D(T x, T y, T z) : base(x, y)
        {
            this.z = z;
        }

        /// <summary>
        /// overrided method string for this class
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return $"({X}; {Y}; {Z})";
        }
    }
}
