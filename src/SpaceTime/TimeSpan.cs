namespace Bearded.Utilities.SpaceTime
{
    public struct TimeSpan
    {
        #region Fields

        private readonly double value;

        #endregion

        #region Constructor

        public TimeSpan(double value)
        {
            this.value = value;
        }

        #endregion


        #region Properties

        public double NumericValue
        {
            get { return this.value; }
        }

        #region Statics

        public static TimeSpan Zero { get { return new TimeSpan(0); } }
        public static TimeSpan One { get { return new TimeSpan(1); } }

        #endregion

        #endregion

        #region Operators

        public static TimeSpan operator +(TimeSpan u0, TimeSpan u1)
        {
            return new TimeSpan(u0.value + u1.value);
        }
        public static TimeSpan operator -(TimeSpan u0, TimeSpan u1)
        {
            return new TimeSpan(u0.value - u1.value);
        }
        public static TimeSpan operator -(TimeSpan u)
        {
            return new TimeSpan(u.value);
        }
        public static TimeSpan operator *(TimeSpan u, float scalar)
        {
            return new TimeSpan(u.value * scalar);
        }
        public static TimeSpan operator *(float scalar, TimeSpan u)
        {
            return new TimeSpan(u.value * scalar);
        }

        public static bool operator ==(TimeSpan u0, TimeSpan u1)
        {
            return u0.value == u1.value;
        }

        public static bool operator !=(TimeSpan u0, TimeSpan u1)
        {
            return !(u0 == u1);
        }

        #endregion

        #region Equals(), GetHashCode(), ToString()

        public bool Equals(TimeSpan other)
        {
            return this.value.Equals(other.value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is TimeSpan && Equals((TimeSpan)obj);
        }

        public override int GetHashCode()
        {
            return this.value.GetHashCode();
        }

        public override string ToString()
        {
            return this.value + "s";
        }

        #endregion
    }
}
