namespace Bearded.Utilities.SpaceTime
{
    public struct Circle
    {
        private readonly Position2 center;
        private readonly Unit radius;

        public Circle(Position2 center, Unit radius)
        {
            this.center = center;
            this.radius = radius;
        }

        public Unit Radius { get { return this.radius; } }
        public Position2 Center { get { return this.center; } }
    }
}
