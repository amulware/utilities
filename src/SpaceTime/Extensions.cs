namespace Bearded.Utilities.SpaceTime
{
    /// <summary>
    /// Contains useful extensions for SpaceTime types.
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Returns a unit value with the given numerical value.
        /// </summary>
        public static Unit U(this float value)
        {
            return new Unit(value);
        }
        /// <summary>
        /// Returns a unit value with the given numerical value.
        /// </summary>
        public static Unit U(this int value)
        {
            return new Unit(value);
        }
    }
}
