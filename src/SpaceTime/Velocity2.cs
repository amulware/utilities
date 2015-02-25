using OpenTK;

namespace Bearded.Utilities.SpaceTime
{
    public struct Velocity2
    {
        private readonly Unit x;
        private readonly Unit y;

        public Velocity2(Vector2 v)
            :this(v.X.Units(), v.Y.Units())
        {
            
        }

        public Velocity2(Unit x, Unit y)
        {
            this.x = x;
            this.y = y;
        }

        public Vector2 Vector { get { return new Vector2(this.x.NumericValue, this.y.NumericValue); } }

        public Unit X { get { return this.x; } }
        public Unit Y { get { return this.y; } }

        public static Velocity2 operator +(Velocity2 v0, Velocity2 v1)
        {
            return new Velocity2(v0.x + v1.x, v0.y + v1.y);
        }

        public static Difference2 operator*(Velocity2 v, TimeSpan t)
        {
            var tAsFloat = (float)t.NumericValue;
            return new Difference2(v.x * tAsFloat, v.y * tAsFloat);
        }
    }
}
