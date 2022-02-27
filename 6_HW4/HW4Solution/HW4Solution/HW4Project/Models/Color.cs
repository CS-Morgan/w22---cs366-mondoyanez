using System;

namespace HW4Project.Models
{
    public class Color
    {
        public int? red { get; set; } = 0;
        public int? green { get; set; } = 0;
        public int? blue { get; set; } = 0;

        public string RGBToHex()
        {
            return red?.ToString("X2") + green?.ToString("X2") + blue?.ToString("X2");
        }

        public Color HexToColor(string hex)
        {
            string RGBR = hex.Substring(0, 2);
            int r = Convert.ToInt32(RGBR, 16);

            string RGBG = hex.Substring(2, 2);
            int g = Convert.ToInt32(RGBR, 16);

            string RGBB = hex.Substring(4, 2);
            int b = Convert.ToInt32(RGBB, 16);

            Color color = new Color() { red = r, green = g, blue = blue };

            return color;
        }

        public double GetHue()
        {
            double hue = 0;

            double redPrime = (double)red / 255;
            double greenPrime = (double)green / 255;
            double bluePrime = (double)blue / 255;

            double colorMax = Math.Max(redPrime, Math.Max(greenPrime, bluePrime));
            double colorMin = Math.Min(redPrime, Math.Min(greenPrime, bluePrime));

            double difference = colorMax - colorMin;

            if (difference.Equals(0))
            {
                hue = 0;
            }
            else if (colorMax.Equals(redPrime))
            {
                hue = Math.Round((greenPrime - bluePrime) / difference);
                hue = hue % 6;
                hue = hue * 60;
            }
            else if (colorMax.Equals(greenPrime))
            {
                hue = Math.Round(60 * (((bluePrime - redPrime) / difference) + 2));
            }
            else if (colorMax.Equals(bluePrime))
            {
                hue = Math.Round(60 * (((redPrime - greenPrime) / difference) + 4));
            }

            return hue;
        }
    }
}
