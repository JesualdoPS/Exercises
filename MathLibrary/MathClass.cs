

namespace MathLibrary
{
    public class MathClass
    {
        public object Absolute(int? inputInt = null, double? inputDouble = null, long? inputLong = null)
        {
            if (inputDouble != null) return Convert.ToDouble(Math.Abs(Convert.ToDouble(inputDouble)));
            if (inputLong != null) return Convert.ToInt64(Math.Abs(Convert.ToInt64(inputLong)));

            return (Convert.ToInt32(Math.Abs(Convert.ToInt32(inputInt))));
        }

        public string ThreeMeanTipes(double[] input)
        {
            double trueMean = Math.Round(input.Average(), 2);
            double awayFromZero = Math.Round(input.Average(), 2, MidpointRounding.AwayFromZero);
            double roundToNearest = Math.Round(input.Average(), 2, MidpointRounding.ToEven);
            return $"True mean: {trueMean}/ Away from zero: {awayFromZero}/ Rounding to nearest: {roundToNearest}";
        }

        public string MilesPerSide(string cityName, double squareMiles)
        {
            return $"{cityName} has {Math.Sqrt(squareMiles).ToString("F2")} miles per side";
        }
    }
}
