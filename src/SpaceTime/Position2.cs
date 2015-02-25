using OpenTK;

namespace Bearded.Utilities.SpaceTime
{
    public struct Position2
    {
        private readonly Unit x;
        private readonly Unit y;

        public Position2(Unit x, Unit y)
        {
            this.x = x;
            this.y = y;
        }

        public Vector2 Vector { get { return new Vector2(this.x.NumericValue, this.y.NumericValue); } }

        public Unit X { get { return this.x; } }
        public Unit Y { get { return this.y; } }

    }
}
