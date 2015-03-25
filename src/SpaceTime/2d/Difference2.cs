using System;
using Bearded.Utilities.Math;
using OpenTK;

namespace Bearded.Utilities.SpaceTime
{
    /// <summary>
    /// Represents a difference or translation between two positions in two dimensional space.
    /// </summary>
    public struct Difference2 : IEquatable<Difference2>
    {
        private readonly Unit x;
        private readonly Unit y;

        #region Constructors

        /// <summary>
        /// Creates a new difference with the given numerical value.
        /// </summary>
        public Difference2(Vector2 v)
            : this(v.X, v.Y)
        {

        }

        /// <summary>
        /// Creates a new difference with the given numerical value.
        /// </summary>
        public Difference2(float x, float y)
            : this(x.U(), y.U())
        {

        }

        /// <summary>
        /// Creates a new difference with the given value.
        /// </summary>
        public Difference2(Unit x, Unit y)
        {
            this.x = x;
            this.y = y;
        }

        #endregion


        #region Methods

        #region Statics

        /// <summary>
        /// Returns the difference between two positions.
        /// </summary>
        public static Difference2 Between(Position2 from, Position2 to)
        {
            return to - from;
        }

        /// <summary>
        /// Returns a difference vector from a direction and length.
        /// </summary>
        /// <param name="direction">The direction of the returned vector.</param>
        /// <param name="length">The length of the returned vector.</param>
        public static Difference2 In(Direction2 direction, Unit length)
        {
            return new Difference2(direction.Vector * length.NumericValue);
        }

        #endregion

        #endregion

        #region Properties

        /// <summary>
        /// Gets the numerical value of this difference as vector.
        /// </summary>
        public Vector2 Vector { get { return new Vector2(this.x.NumericValue, this.y.NumericValue); } }

        /// <summary>
        /// Gets this difference's translation in X direction.
        /// </summary>
        public Unit X { get { return this.x; } }
        /// <summary>
        /// Gets this difference's translation in Y direction.
        /// </summary>
        public Unit Y { get { return this.y; } }

        /// <summary>
        /// Gets the squared length of this difference.
        /// </summary>
        public RadiusSquared LengthSquared { get { return this.x.Squared + this.y.Squared; } }
        /// <summary>
        /// Gets the length of this difference.
        /// </summary>
        public Radius Length { get { return (this.x.Squared + this.y.Squared).Sqrt; } }
        /// <summary>
        /// Gets the direction of this difference.
        /// </summary>
        public Direction2 Direction { get { return Direction2.Of(this.Vector); } }

        #endregion

        #region Operators


        /// <summary>
        /// Adds two differences.
        /// </summary>
        public static Difference2 operator +(Difference2 d0, Difference2 d1)
        {
            return new Difference2(d0.x + d1.x, d0.y + d1.y);
        }
        /// <summary>
        /// Substracts one difference from another.
        /// </summary>
        public static Difference2 operator -(Difference2 d0, Difference2 d1)
        {
            return new Difference2(d0.x + d1.x, d0.y + d1.y);
        }
        /// <summary>
        /// Inverts a difference.
        /// </summary>
        public static Difference2 operator -(Difference2 d)
        {
            return new Difference2(-d.x, -d.y);
        }
        /// <summary>
        /// Scales a difference with a scalar.
        /// </summary>
        public static Difference2 operator *(Difference2 d, float scalar)
        {
            return new Difference2(d.x * scalar, d.y * scalar);
        }
        /// <summary>
        /// Scales a difference with a scalar.
        /// </summary>
        public static Difference2 operator *(float scalar, Difference2 d)
        {
            return new Difference2(d.x * scalar, d.y * scalar);
        }
        /// <summary>
        /// Checks two differences for equality.
        /// </summary>
        public static bool operator ==(Difference2 d0, Difference2 d1)
        {
            return d0.x == d1.x && d0.y == d1.y;
        }
        /// <summary>
        /// Checks two differences for inequality.
        /// </summary>
        public static bool operator !=(Difference2 d0, Difference2 d1)
        {
            return !(d0 == d1);
        }
        /// <summary>
        /// Divides a difference by a time span.
        /// </summary>
        /// <returns>The velocity that is required to translate the difference in the given time span.</returns>
        public static Velocity2 operator /(Difference2 d, TimeSpan t)
        {
            var tInvAsFloat = (float)(1 / t.NumericValue);
            return new Velocity2(d.x * tInvAsFloat, d.y * tInvAsFloat);
        }


        #endregion

        #region Equals(), GetHashCode(), ToString()

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        public bool Equals(Difference2 other)
        {
            return this.x.Equals(other.x) && this.y.Equals(other.y);
        }

        /// <summary>
        /// Indicates whether this instance and a specified object are equal.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is Difference2 && this.Equals((Difference2)obj);
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
