namespace Bearded.Utilities.SpaceTime
{
    static class Extensions
    {
        public static Unit Units(this float value)
        {
            return new Unit(value);
        }

        public static TimeSpan Seconds(this double value)
        {
            return new TimeSpan(value);
        }
    }
}
