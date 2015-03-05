using System;
using Bearded.Utilities.Math;
using OpenTK;

namespace Bearded.Utilities.SpaceTime
{
    /// <summary>
    /// Represents a velocity vector in two dimensional space.
    /// </summary>
    public struct Velocity2 : IEquatable<Velocity2>
    {
        private readonly Unit x;
        private readonly Unit y;

        #region Constructors

        /// <summary>
        /// Initialises a velocity with the given numerical value.
        /// </summary>
        public Velocity2(Vector2 v)
            :this(v.X, v.Y)
        {
            
        }

        /// <summary>
        /// Initialises a velocity with the given numerical value.
        /// </summary>
        public Velocity2(float x, float y)
            : this(x.U(), y.U())
        {
        }

        /// <summary>
        /// Initialises a velocity with the given value.
        /// </summary>
        public Velocity2(Unit x, Unit y)
        {
            this.x = x;
            this.y = y;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the numerical value of the velocity as vector.
        /// </summary>
        public Vector2 Vector { get { return new Vector2(this.x.NumericValue, this.y.NumericValue); } }

        /// <summary>
        /// Gets this velocity's translation in X direction.
        /// </summary>
        public Unit X { get { return this.x; } }

        /// <summary>
        /// Gets this velocity's translation in Y direction.
        /// </summary>
        public Unit Y { get { return this.y; } }

        /// <summary>
        /// Gets the speed of this velocity. This corresponds to the length of the velocity vector.
        /// </summary>
        public Speed Speed { get { return new Speed((this.x.Squared + this.y.Squared).Sqrt); } }

        /// <summary>
        /// Gets the direction of this velocity.
        /// </summary>
        public Direction2 Direction { get { return Direction2.Of(this.Vector); } }

        #endregion

        #region Operators

        /// <summary>
        /// Adds two velocities.
        /// </summary>
        public static Velocity2 operator +(Velocity2 v0, Velocity2 v1)
        {
            return new Velocity2(v0.x + v1.x, v0.y + v1.y);
        }
        /// <summary>
        /// Substracts one velocity from another.
        /// </summary>
        public static Velocity2 operator -(Velocity2 v0, Velocity2 v1)
        {
            return new Velocity2(v0.x - v1.x, v0.y - v1.y);
        }
        /// <summary>
        /// Inverts a velocity.
        /// </summary>
        public static Velocity2 operator -(Velocity2 v)
        {
            return new Velocity2(-v.x, -v.y);
        }
        /// <summary>
        /// Scales the velocity by a scalar.
        /// </summary>
        public static Velocity2 operator *(Velocity2 v, float scalar)
        {
            return new Velocity2(v.x * scalar, v.y * scalar);
        }
        /// <summary>
        /// Scales the velocity by a scalar.
        /// </summary>
        public static Velocity2 operator *(float scalar, Velocity2 v)
        {
            return new Velocity2(v.x * scalar, v.y * scalar);
        }

        /// <summary>
        /// Checks two velocities for equality.
        /// </summary>
        public static bool operator ==(Velocity2 v0, Velocity2 v1)
        {
            return v0.x == v1.x && v0.y == v1.y;
        }

        /// <summary>
        /// Checks two velocities for inequality.
        /// </summary>
        public static bool operator !=(Velocity2 v0, Velocity2 v1)
        {
            return !(v0 == v1);
        }

        /// <summary>
        /// Multiplies a velocity with a time span to obtain the corresponding translation.
        /// </summary>
        public static Difference2 operator*(Velocity2 v, TimeSpan t)
        {
            var tAsFloat = (float)t.NumericValue;
            return new Difference2(v.x * tAsFloat, v.y * tAsFloat);
        }

        #endregion


        #region Equals(), GetHashCode(), ToString()

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        public bool Equals(Velocity2 other)
        {
            return this.x.Equals(other.x) && this.y.Equals(other.y);
        }

        /// <summary>
        /// Indicates whether this instance and a specified object are equal.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is Velocity2 && this.Equals((Velocity2)obj);
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
            return "{" + this.x + "/t," + this.y + "/t}";
        }

        #endregion
    }
}
