using System;
using Bearded.Utilities.Math;

namespace Bearded.Utilities.SpaceTime
{
    /// <summary>
    /// Represents an absolute speed.
    /// </summary>
    public struct Speed : IEquatable<Speed>, IComparable<Speed>
    {
        private readonly Radius value;
        
        #region Constructors

        internal Speed(Radius value)
        {
            this.value = value;
        }
        internal Speed(float value)
            : this(new Radius(value))
        {
        }

        #endregion

        #region Methods

        #region Statics

        /// <summary>
        /// Returns a Speed instance with the given value.
        /// </summary>
        /// <exception cref="ArgumentException">Throws if the given value is negative</exception>
        public static Speed FromValue(float value)
        {
            if (value < 0)
                throw new ArgumentException("Speed value has to be non negative.", "value");
            return new Speed(value);
        }
        /// <summary>
        /// Returns a Speed instance with the given value.
        /// </summary>
        /// <exception cref="ArgumentException">Throws if the given value is negative</exception>
        public static Speed FromValue(Unit value)
        {
            if (value < Unit.Zero)
                throw new ArgumentException("Speed value has to be non negative.", "value");
            return new Speed(value.NumericValue);
        }
        /// <summary>
        /// Returns a Speed instance with the given value.
        /// </summary>
        public static Speed FromValue(Radius value)
        {
            return new Speed(value);
        }

        #endregion

        #endregion

        #region Properties

        /// <summary>
        /// Gets the numerical value of this speed.
        /// </summary>
        public float NumericValue { get { return this.value.NumericValue; } }

        #endregion

        #region Operators

        /// <summary>
        /// Checks if the first speed is smaller than the second.
        /// </summary>
        public static bool operator <(Speed s0, Speed s1)
        {
            return s0.value < s1.value;
        }
        /// <summary>
        /// Checks if the first speed is larger than the second.
        /// </summary>
        public static bool operator >(Speed s0, Speed s1)
        {
            return s0.value > s1.value;
        }
        /// <summary>
        /// Checks if the first speed is smaller than or equal to the second.
        /// </summary>
        public static bool operator <=(Speed s0, Speed s1)
        {
            return s0.value < s1.value;
        }
        /// <summary>
        /// Checks if the first speed is larger than or equal to the second.
        /// </summary>
        public static bool operator >=(Speed s0, Speed s1)
        {
            return s0.value >= s1.value;
        }

        /// <summary>
        /// Checks two speeds for equality.
        /// </summary>
        public static bool operator ==(Speed s0, Speed s1)
        {
            return s0.value == s1.value;
        }

        /// <summary>
        /// Checks two speeds for inequality.
        /// </summary>
        public static bool operator !=(Speed s0, Speed s1)
        {
            return !(s0 == s1);
        }

        /// <summary>
        /// Combines a direction with a speed to create a directed Velocity.
        /// </summary>
        public static Velocity2 operator *(Direction2 d, Speed s)
        {
            return new Velocity2(d.Vector * s.value.NumericValue);
        }
        /// <summary>
        /// Combines a direction with a speed to create a directed Velocity.
        /// </summary>
        public static Velocity2 operator *(Speed s, Direction2 d)
        {
            return new Velocity2(d.Vector * s.value.NumericValue);
        }

        #endregion

        #region Equals(), CompareTo(), GetHashCode(), ToString()

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        public bool Equals(Speed other)
        {
            return this.value.Equals(other.value);
        }

        /// <summary>
        /// Indicates whether this instance and a specified object are equal.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is Speed && this.Equals((Speed)obj);
        }

        /// <summary>
        /// Compares the current object with another object of the same type.
        /// </summary>
        public int CompareTo(Speed other)
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
        /// Returns a string representing this speed.
        /// </summary>
        public override string ToString()
        {
            return this.value + "/t";
        }

        #endregion
    }
}
