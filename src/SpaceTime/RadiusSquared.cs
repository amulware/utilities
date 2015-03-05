using System;
using Bearded.Utilities.Math;

namespace Bearded.Utilities.SpaceTime
{
    /// <summary>
    /// Represents the squared value of a radius or distance.
    /// </summary>
    public struct RadiusSquared : IEquatable<RadiusSquared>, IComparable<RadiusSquared>
    {
        private readonly float value;

        #region Constructors

        internal RadiusSquared(float value)
        {
            this.value = value;
        }

        #endregion

        #region Methods

        #region Statics

        /// <summary>
        /// Returns a new squared radius or distance.
        /// </summary>
        /// <exception cref="ArgumentException">Throws if the given value is negative</exception>
        public static RadiusSquared FromValue(float value)
        {
            if (value < 0)
                throw new ArgumentException("Radius squared value has to be non negative.", "value");
            return new RadiusSquared(value);
        }
        #endregion

        #endregion

        #region Properties

        /// <summary>
        /// Gets the square root of this squared radius.
        /// </summary>
        public Radius Sqrt
        {
            get { return new Radius(this.value.Sqrted()); }
        }

        /// <summary>
        /// Gets the numerical value of this squared radius.
        /// </summary>
        public float NumericValue
        {
            get { return this.value; }
        }

        #endregion

        #region Operators

        /// <summary>
        /// Adds two squared radii.
        /// </summary>
        public static RadiusSquared operator +(RadiusSquared r0, RadiusSquared r1)
        {
            return new RadiusSquared(r0.value + r1.value);
        }
        /// <summary>
        /// Checks if one squared radius is smaller than another.
        /// </summary>
        public static bool operator <(RadiusSquared r0, RadiusSquared r1)
        {
            return r0.value < r1.value;
        }
        /// <summary>
        /// Checks if one squared radius is larger than another.
        /// </summary>
        public static bool operator >(RadiusSquared r0, RadiusSquared r1)
        {
            return r0.value > r1.value;
        }
        /// <summary>
        /// Checks if one squared radius is smaller than or equal to another.
        /// </summary>
        public static bool operator <=(RadiusSquared r0, RadiusSquared r1)
        {
            return r0.value <= r1.value;
        }
        /// <summary>
        /// Checks if one squared radius is larger than or equal to another.
        /// </summary>
        public static bool operator >=(RadiusSquared r0, RadiusSquared r1)
        {
            return r0.value >= r1.value;
        }

        /// <summary>
        /// Checks two squared radii for equality.
        /// </summary>
        public static bool operator ==(RadiusSquared r0, RadiusSquared r1)
        {
            return r0.value == r1.value;
        }

        /// <summary>
        /// Checks two squared radii for inequality.
        /// </summary>
        public static bool operator !=(RadiusSquared r0, RadiusSquared r1)
        {
            return !(r0 == r1);
        }
        #endregion

        #region Equals(), CompareTo(), GetHashCode(), ToString()

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        public bool Equals(RadiusSquared other)
        {
            return this.value.Equals(other.value);
        }

        /// <summary>
        /// Indicates whether this instance and a specified object are equal.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is RadiusSquared && this.Equals((RadiusSquared)obj);
        }

        /// <summary>
        /// Compares the current object with another object of the same type.
        /// </summary>
        public int CompareTo(RadiusSquared other)
        {
            return this.value.CompareTo(other.value);
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            return this.value.GetHashCode();
        }

        /// <summary>
        /// Returns a string representing this squared radius.
        /// </summary>
        public override string ToString()
        {
            return this.value + "u²";
        }

        #endregion
    }
}
