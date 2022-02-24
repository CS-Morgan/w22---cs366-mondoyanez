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

        public double GetHue()
        {
            int min = Math.Min((int)red, Math.Min((int)green, (int)blue));
            double hue;

            if (red > green && red > blue)
            {
                int max = (int)red;
                hue = (double)(green - blue) / (max - min);
            }
            else if (green > red && green > blue)
            {
                int max = (int)green;
                hue = (double)(2.0 + (blue - red) / (max - min));
            }
            else
            {
                int max = (int)blue;
                hue = (double)(4.0 + (red - green) / (max - min));
            }

            return hue;
        }

        public static Color FromArgb(int v1, int v2, int t, int p)
        {
            throw new NotImplementedException();
        }
    }
}
