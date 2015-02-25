namespace Bearded.Utilities.SpaceTime
{
    struct Unit
    {
        #region Fields

        private readonly float value;

        #endregion

        #region Constructor

        public Unit(float value)
        {
            this.value = value;
        }

        #endregion

        #region Properties

        public float NumericValue
        {
            get { return this.value; }
        }

        #region Statics

        public static Unit Zero { get { return new Unit(0); } }
        public static Unit One { get { return new Unit(1); } }

        #endregion

        #endregion

        #region Operators

        public static Unit operator +(Unit u0, Unit u1)
        {
            return new Unit(u0.value + u1.value);
        }
        public static Unit operator -(Unit u0, Unit u1)
        {
            return new Unit(u0.value - u1.value);
        }
        public static Unit operator -(Unit u)
        {
            return new Unit(u.value);
        }
        public static Unit operator *(Unit u, float scalar)
        {
            return new Unit(u.value * scalar);
        }
        public static Unit operator *(float scalar, Unit u)
        {
            return new Unit(u.value * scalar);
        }

        public static bool operator ==(Unit u0, Unit u1)
        {
            return u0.value == u1.value;
        }

        public static bool operator !=(Unit u0, Unit u1)
        {
            return !(u0 == u1);
        }

        #endregion

        #region Equals(), GetHashCode(), ToString()

        public bool Equals(Unit other)
        {
            return this.value.Equals(other.value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is Unit && Equals((Unit)obj);
        }

        public override int GetHashCode()
        {
            return this.value.GetHashCode();
        }

        public override string ToString()
        {
            return this.value + "u";
        }

        #endregion
    }
}
