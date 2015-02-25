namespace Bearded.Utilities.SpaceTime
{
    struct Instant
    {
        #region Fields

        private readonly double value;

        #endregion

        #region Constructor

        public Instant(double value)
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

        public static Instant Zero { get { return new Instant(0); } }

        #endregion

        #endregion

        #region Operators

        public static Instant operator +(Instant i, TimeSpan t)
        {
            return new Instant(i.value + t.NumericValue);
        }

        public static Instant operator -(Instant i, TimeSpan t)
        {
            return new Instant(i.value - t.NumericValue);
        }

        public static bool operator ==(Instant i0, Instant i1)
        {
            return i0.value == i1.value;
        }

        public static bool operator !=(Instant i0, Instant i1)
        {
            return !(i0 == i1);
        }

        #endregion

        #region Equals(), GetHashCode(), ToString()

        public bool Equals(Instant other)
        {
            return this.value.Equals(other.value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is Instant && Equals((Instant)obj);
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
