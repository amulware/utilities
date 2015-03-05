using System;

namespace Bearded.Utilities.SpaceTime
{
    /// <summary>
    /// Represents the relative time span between two absolute time instants.
    /// </summary>
    public struct TimeSpan : IEquatable<TimeSpan>, IComparable<TimeSpan>
    {
        #region Fields

        private readonly double value;

        #endregion

        #region Constructor

        /// <summary>
        /// Initialises a time span with the given numerical value;
        /// </summary>
        public TimeSpan(double value)
        {
            this.value = value;
        }

        #endregion

        #region Methods

        #region Statics

        /// <summary>
        /// Returns the time span between two instances in time.
        /// </summary>
        public static TimeSpan Between(Instant from, Instant to)
        {
            return to - from;
        }

        #endregion

        #endregion

        #region Properties

        /// <summary>
        /// Gets the numerical value of this time span.
        /// </summary>
        public double NumericValue
        {
            get { return this.value; }
        }

        #region Statics

        /// <summary>
        /// The default Zero time span.
        /// </summary>
        public static TimeSpan Zero { get { return new TimeSpan(0); } }
        /// <summary>
        /// The default One time span.
        /// </summary>
        public static TimeSpan One { get { return new TimeSpan(1); } }

        #endregion

        #endregion

        #region Operators

        /// <summary>
        /// Adds two time spans.
        /// </summary>
        public static TimeSpan operator +(TimeSpan t0, TimeSpan t1)
        {
            return new TimeSpan(t0.value + t1.value);
        }

        /// <summary>
        /// Substracts one time span from another.
        /// </summary>
        public static TimeSpan operator -(TimeSpan t0, TimeSpan t1)
        {
            return new TimeSpan(t0.value - t1.value);
        }

        /// <summary>
        /// Inverts a time span.
        /// </summary>
        public static TimeSpan operator -(TimeSpan t)
        {
            return new TimeSpan(t.value);
        }
        /// <summary>
        /// Multiplies a time span by a scalar.
        /// </summary>
        public static TimeSpan operator *(TimeSpan t, double scalar)
        {
            return new TimeSpan(t.value * scalar);
        }
        /// <summary>
        /// Multiplies a time span by a scalar.
        /// </summary>
        public static TimeSpan operator *(double scalar, TimeSpan t)
        {
            return new TimeSpan(t.value * scalar);
        }

        /// <summary>
        /// Checks if one time span is smaller than another.
        /// </summary>
        public static bool operator <(TimeSpan t0, TimeSpan t1)
        {
            return t0.value < t1.value;
        }
        /// <summary>
        /// Checks if one time span is larger than another.
        /// </summary>
        public static bool operator >(TimeSpan t0, TimeSpan t1)
        {
            return t0.value > t1.value;
        }
        /// <summary>
        /// Checks if one time span is smaller than or equal to another.
        /// </summary>
        public static bool operator <=(TimeSpan t0, TimeSpan t1)
        {
            return t0.value < t1.value;
        }
        /// <summary>
        /// Checks if one time span is larger than or equal to another.
        /// </summary>
        public static bool operator >=(TimeSpan t0, TimeSpan t1)
        {
            return t0.value >= t1.value;
        }

        /// <summary>
        /// Checks two time spans for equality;
        /// </summary>
        public static bool operator ==(TimeSpan t0, TimeSpan t1)
        {
            return t0.value == t1.value;
        }

        /// <summary>
        /// Checks two time spans for inequality;
        /// </summary>
        public static bool operator !=(TimeSpan t0, TimeSpan t1)
        {
            return !(t0 == t1);
        }

        #endregion

        #region Equals(), CompareTo(), GetHashCode(), ToString()

        /// <summary>
        /// Indicates whether the current time span is equal to another one.
        /// </summary>
        public bool Equals(TimeSpan other)
        {
            return this.value.Equals(other.value);
        }

        /// <summary>
        /// Indicates whether this instance and a specified object are equal.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is TimeSpan && this.Equals((TimeSpan)obj);
        }

        /// <summary>
        /// Compares the current time span with another one.
        /// </summary>
        public int CompareTo(TimeSpan other)
        {
            return this.value.CompareTo(other.value);
        }

        /// <summary>
        /// Returns the hash code for this time span.
        /// </summary>
        public override int GetHashCode()
        {
            return this.value.GetHashCode();
        }

        /// <summary>
        /// Returns a string representing this time span.
        /// </summary>
        public override string ToString()
        {
            return this.value + "t";
        }

        #endregion
    }
}
