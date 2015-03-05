using System;
using OpenTK;

namespace Bearded.Utilities.SpaceTime
{
    /// <summary>
    /// Represents a position in two dimensional space.
    /// </summary>
    public struct Position2 : IEquatable<Position2>
    {
        private readonly Unit x;
        private readonly Unit y;

        #region Constructors

        /// <summary>
        /// Initialises a new position with the given numerical value.
        /// </summary>
        public Position2(Vector2 p)
            :this(p.X, p.Y)
        {
        }

        /// <summary>
        /// Initialises a new position with the given numerical value.
        /// </summary>
        public Position2(float x, float y)
            :this(x.U(), y.U())
        {
        }

        /// <summary>
        /// Initialises a new position with the given value.
        /// </summary>
        public Position2(Unit x, Unit y)
        {
            this.x = x;
            this.y = y;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the numerical value of this position as vector.
        /// </summary>
        public Vector2 Vector { get { return new Vector2(this.x.NumericValue, this.y.NumericValue); } }

        /// <summary>
        /// Gets the X coordinate of this position.
        /// </summary>
        public Unit X { get { return this.x; } }

        /// <summary>
        /// Gets the Y coordinate of this position.
        /// </summary>
        public Unit Y { get { return this.y; } }

        #endregion

        #region Operators

        /// <summary>
        /// Gets the difference between two positions.
        /// </summary>
        public static Difference2 operator -(Position2 p0, Position2 p1)
        {
            return new Difference2(p0.x - p1.x, p0.y - p1.y);
        }

        /// <summary>
        /// Translates a position by a given difference.
        /// </summary>
        public static Position2 operator +(Position2 p, Difference2 d)
        {
            return new Position2(p.x + d.X, p.y + d.Y);
        }

        /// <summary>
        /// Translates a position by the inverse of a given difference.
        /// </summary>
        public static Position2 operator -(Position2 p, Difference2 d)
        {
            return new Position2(p.x - d.X, p.y - d.Y);
        }

        /// <summary>
        /// Checks two positions for equality.
        /// </summary>
        public static bool operator ==(Position2 p0, Position2 p1)
        {
            return p0.Equals(p1);
        }

        /// <summary>
        /// Checks two positions for inequality.
        /// </summary>
        public static bool operator !=(Position2 p0, Position2 p1)
        {
            return !(p0 == p1);
        }
        #endregion

        #region Equals(), GetHashCode(), ToString()

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        public bool Equals(Position2 other)
        {
            return this.x.Equals(other.x) && this.y.Equals(other.y);
        }

        /// <summary>
        /// Indicates whether this instance and a specified object are equal.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is Position2 && this.Equals((Position2)obj);
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return (this.x.GetHashCode() * 397) ^ this.y.GetHashCode();
            }
        }

        /// <summary>
        /// Returns the fully qualified type name of this instance.
        /// </summary>
        public override string ToString()
        {
            return "{" + this.x + "," + this.y + "}";
        }

        #endregion
    }
}
