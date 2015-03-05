using System;
using Bearded.Utilities.Math;

namespace Bearded.Utilities.SpaceTime
{
    /// <summary>
    /// Represents a one dimensional spacial coordinate.
    /// </summary>
    public struct Unit : IEquatable<Unit>, IComparable<Unit>
    {
        #region Fields

        private readonly float value;

        #endregion

        #region Constructor

        /// <summary>
        /// Initialises a new unit with the given numeric value.
        /// </summary>
        public Unit(float value)
        {
            this.value = value;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the numerical value of the stored unit type.
        /// </summary>
        public float NumericValue
        {
            get { return this.value; }
        }

        /// <summary>
        /// Gets the square of the unit.
        /// </summary>
        public RadiusSquared Squared { get { return new RadiusSquared(this.value.Squared()); } }

        #region Statics

        /// <summary>
        /// Default Zero unit.
        /// </summary>
        public static Unit Zero { get { return new Unit(0); } }

        /// <summary>
        /// Default One unit.
        /// </summary>
        public static Unit One { get { return new Unit(1); } }

        #endregion

        #endregion

        #region Operators

        /// <summary>
        /// Adds two unit values.
        /// </summary>
        public static Unit operator +(Unit u0, Unit u1)
        {
            return new Unit(u0.value + u1.value);
        }
        /// <summary>
        /// Substracts two unit values.
        /// </summary>
        public static Unit operator -(Unit u0, Unit u1)
        {
            return new Unit(u0.value - u1.value);
        }

        /// <summary>
        /// Inverts a unit value.
        /// </summary>
        public static Unit operator -(Unit u)
        {
            return new Unit(-u.value);
        }

        /// <summary>
        /// Scales a unit value with a scalar.
        /// </summary>
        public static Unit operator *(Unit u, float scalar)
        {
            return new Unit(u.value * scalar);
        }

        /// <summary>
        /// Scales a unit value with a scalar.
        /// </summary>
        public static Unit operator *(float scalar, Unit u)
        {
            return new Unit(u.value * scalar);
        }

        /// <summary>
        /// Checks wether the first unit value is smaller than the second one.
        /// </summary>
        public static bool operator <(Unit u0, Unit u1)
        {
            return u0.value < u1.value;
        }
        /// <summary>
        /// Checks wether the first unit value is larger than the second one.
        /// </summary>
        public static bool operator >(Unit u0, Unit u1)
        {
            return u0.value > u1.value;
        }

        /// <summary>
        /// Checks wether the first unit value is smaller than or equal to the second one.
        /// </summary>
        public static bool operator <=(Unit u0, Unit u1)
        {
            return u0.value <= u1.value;
        }

        /// <summary>
        /// Checks wether the first unit value is larger than or equal to the second one.
        /// </summary>
        public static bool operator >=(Unit u0, Unit u1)
        {
            return u0.value >= u1.value;
        }

        /// <summary>
        /// Checks two unit values for equality.
        /// </summary>
        public static bool operator ==(Unit u0, Unit u1)
        {
            return u0.value == u1.value;
        }

        /// <summary>
        /// Checks two unit values for inequality.
        /// </summary>
        public static bool operator !=(Unit u0, Unit u1)
        {
            return !(u0 == u1);
        }

        #endregion

        #region Equals(), CompareTo(), GetHashCode(), ToString()

        /// <summary>
        /// Indicates whether the current unit value is equal to another one.
        /// </summary>
        public bool Equals(Unit other)
        {
            return this.value.Equals(other.value);
        }

        /// <summary>
        /// Indicates whether this instance and a specified object are equal.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is Unit && this.Equals((Unit)obj);
        }

        /// <summary>
        /// Compares the current unit value with another one.
        /// </summary>
        public int CompareTo(Unit other)
        {
            return this.value.CompareTo(other.value);
        }

        /// <summary>
        /// Returns the hash code for this unit value.
        /// </summary>
        public override int GetHashCode()
        {
            return this.value.GetHashCode();
        }

        /// <summary>
        /// Returns the string representation of this unit value.
        /// </summary>
        public override string ToString()
        {
            return this.value + "u";
        }

        #endregion
    }
}
