using System;

namespace Bearded.Utilities.SpaceTime
{
    /// <summary>
    /// Represents an absolute instant in time.
    /// </summary>
    public struct Instant : IEquatable<Instant>, IComparable<Instant>
    {
        #region Fields

        private readonly double value;

        #endregion

        #region Constructor

        /// <summary>
        /// Initialises a new instant with given numerical value.
        /// </summary>
        public Instant(double value)
        {
            this.value = value;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Returns the numerical value of this instant.
        /// </summary>
        public double NumericValue
        {
            get { return this.value; }
        }

        #region Statics

        /// <summary>
        /// The default Zero instant.
        /// </summary>
        public static Instant Zero { get { return new Instant(0); } }

        #endregion

        #endregion

        #region Operators

        /// <summary>
        /// Adds a time span to an instant.
        /// </summary>
        public static Instant operator +(Instant i, TimeSpan t)
        {
            return new Instant(i.value + t.NumericValue);
        }

        /// <summary>
        /// Substracts a time span from an instant.
        /// </summary>
        public static Instant operator -(Instant i, TimeSpan t)
        {
            return new Instant(i.value - t.NumericValue);
        }

        /// <summary>
        /// Gets the time span between two instants in time.
        /// </summary>
        public static TimeSpan operator -(Instant to, Instant from)
        {
            return new TimeSpan(to.value - from.value);
        }

        /// <summary>
        /// Checks if one instant in time is smaller than another.
        /// </summary>
        public static bool operator <(Instant t0, Instant t1)
        {
            return t0.value < t1.value;
        }
        /// <summary>
        /// Checks if one instant in time is larger than another.
        /// </summary>
        public static bool operator >(Instant t0, Instant t1)
        {
            return t0.value > t1.value;
        }
        /// <summary>
        /// Checks if one instant in time is smaller than or equal to another.
        /// </summary>
        public static bool operator <=(Instant t0, Instant t1)
        {
            return t0.value < t1.value;
        }
        /// <summary>
        /// Checks if one instant in time is larger than or equal to another.
        /// </summary>
        public static bool operator >=(Instant t0, Instant t1)
        {
            return t0.value >= t1.value;
        }

        /// <summary>
        /// Checks two instants for equality.
        /// </summary>
        public static bool operator ==(Instant i0, Instant i1)
        {
            return i0.value == i1.value;
        }

        /// <summary>
        /// Checks two instants for inequality.
        /// </summary>
        public static bool operator !=(Instant i0, Instant i1)
        {
            return !(i0 == i1);
        }

        #endregion

        #region Equals(), GetHashCode(), ToString()

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        public bool Equals(Instant other)
        {
            return this.value.Equals(other.value);
        }

        /// <summary>
        /// Indicates whether this instance and a specified object are equal.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is Instant && this.Equals((Instant)obj);
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            return this.value.GetHashCode();
        }

        /// <summary>
        /// Compares the current object with another object of the same type.
        /// </summary>
        public int CompareTo(Instant other)
        {
            return this.value.CompareTo(other.value);
        }

        /// <summary>
        /// Returns a string representing this instant in time.
        /// </summary>
        public override string ToString()
        {
            return this.value + "t";
        }

        #endregion
    }
}
