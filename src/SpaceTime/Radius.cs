using System;

namespace Bearded.Utilities.SpaceTime
{
    /// <summary>
    /// Represents a radius or distance.
    /// </summary>
    public struct Radius : IEquatable<Radius>, IComparable<Radius>
    {
        private readonly Unit value;

        #region Constructors

        internal Radius(Unit value)
        {
            this.value = value;
        }
        internal Radius(float value)
            : this(value.U())
        {
        }

        #endregion

        #region Methods

        #region Statics

        /// <summary>
        /// Returns a new radius with the given value.
        /// </summary>
        /// <exception cref="ArgumentException">Throws if the given value is negative.</exception>
        public static Radius FromValue(float value)
        {
            if (value < 0)
                throw new ArgumentException("Radius value has to be non negative.", "value");
            return new Radius(value);
        }
        /// <summary>
        /// Returns a new radius with the given value.
        /// </summary>
        /// <exception cref="ArgumentException">Throws if the given value is negative.</exception>
        public static Radius FromValue(Unit value)
        {
            if (value < Unit.Zero)
                throw new ArgumentException("Radius value has to be non negative.", "value");
            return new Radius(value);
        }

        #endregion

        #endregion

        #region Properties

        /// <summary>
        /// Gets the value of this radius in units.
        /// </summary>
        public Unit Units { get { return this.value; } }

        /// <summary>
        /// Gets the numerical value of this radius.
        /// </summary>
        public float NumericValue { get { return this.value.NumericValue; } }

        /// <summary>
        /// Gets the square of this radius.
        /// </summary>
        public RadiusSquared Squared { get { return this.value.Squared; } }

        #region Statics

        /// <summary>
        /// Gets the default Zero radius.
        /// </summary>
        public static Radius Zero { get { return new Radius(0); } }

        #endregion

        #endregion

        #region Operators

        /// <summary>
        /// Checks if one radius is smaller than another.
        /// </summary>
        public static bool operator <(Radius r0, Radius r1)
        {
            return r0.value < r1.value;
        }
        /// <summary>
        /// Checks if one radius is larger than another.
        /// </summary>
        public static bool operator >(Radius r0, Radius r1)
        {
            return r0.value > r1.value;
        }
        /// <summary>
        /// Checks if one radius is smaller than or equal to another.
        /// </summary>
        public static bool operator <=(Radius r0, Radius r1)
        {
            return r0.value < r1.value;
        }
        /// <summary>
        /// Checks if one radius is larger than or equal to another.
        /// </summary>
        public static bool operator >=(Radius r0, Radius r1)
        {
            return r0.value >= r1.value;
        }

        /// <summary>
        /// Checks two radii for equality.
        /// </summary>
        public static bool operator ==(Radius r0, Radius r1)
        {
            return r0.value == r1.value;
        }

        /// <summary>
        /// Checks two radii for inequality.
        /// </summary>
        public static bool operator !=(Radius r0, Radius r1)
        {
            return !(r0 == r1);
        }

        /// <summary>
        /// Casts a radius to its unit value.
        /// </summary>
        public static explicit operator Unit(Radius r)
        {
            return r.value;
        }

        #endregion


        #region Equals(), CompareTo(), GetHashCode(), ToString()

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        public bool Equals(Radius other)
        {
            return this.value.Equals(other.value);
        }


        /// <summary>
        /// Indicates whether this instance and a specified object are equal.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is Radius && this.Equals((Radius)obj);
        }

        /// <summary>
        /// Compares the current object with another object of the same type.
        /// </summary>
        public int CompareTo(Radius other)
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
        /// Gets a string representing this radius.
        /// </summary>
        public override string ToString()
        {
            return this.value.ToString();
        }

        #endregion
    }
}
