using System;

namespace Bearded.Utilities.SpaceTime
{
    /// <summary>
    /// Represents a circle in two dimensional space.
    /// </summary>
    public struct Circle : IEquatable<Circle>
    {
        private readonly Position2 center;
        private readonly Radius radius;

        #region Constructors

        /// <summary>
        /// Initialises a new circle with a given center and radius.
        /// </summary>
        public Circle(Position2 center, Radius radius)
        {
            this.center = center;
            this.radius = radius;
        }

        #endregion

        #region Methods

        #endregion

        #region Properties

        /// <summary>
        /// Gets the radius of the circle.
        /// </summary>
        public Radius Radius { get { return this.radius; } }
        /// <summary>
        /// Gets the center of the circle.
        /// </summary>
        public Position2 Center { get { return this.center; } }

        #endregion

        #region Operators

        /// <summary>
        /// Checks two circles for equality.
        /// </summary>
        public static bool operator ==(Circle c0, Circle c1)
        {
            return c0.Center == c1.center && c0.radius == c1.radius;
        }

        /// <summary>
        /// Checks two circles for inequality.
        /// </summary>
        public static bool operator !=(Circle c0, Circle c1)
        {
            return !(c0 == c1);
        }

        #endregion

        #region Equals(), GetHashCode(), ToString()

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        public bool Equals(Circle other)
        {
            return this == other;
        }

        /// <summary>
        /// Indicates whether this instance and a specified object are equal.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is Circle && this.Equals((Circle)obj);
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return (this.center.GetHashCode() * 397) ^ this.radius.GetHashCode();
            }
        }

        /// <summary>
        /// Returns the fully qualified type name of this instance.
        /// </summary>
        public override string ToString()
        {
            return "{" + this.center + "," + this.radius + "}";
        }

        #endregion
    }
}
