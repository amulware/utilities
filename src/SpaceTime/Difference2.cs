using Bearded.Utilities.Math;
using OpenTK;

namespace Bearded.Utilities.SpaceTime
{
    public struct Difference2
    {
        private readonly Unit x;
        private readonly Unit y;

        public Difference2(Vector2 v)
            :this(v.X.Units(), v.Y.Units())
        {
            
        }

        public Difference2(Unit x, Unit y)
        {
            this.x = x;
            this.y = y;
        }

        public Vector2 Vector { get { return new Vector2(this.x.NumericValue, this.y.NumericValue); } }

        public Unit X { get { return this.x; } }
        public Unit Y { get { return this.y; } }

        public float LengthSquared { get { return this.x.NumericValue.Squared() + this.y.NumericValue.Squared(); } }
        public Direction2 Direction { get { return Direction2.Of(this.Vector); } }
    }
}
