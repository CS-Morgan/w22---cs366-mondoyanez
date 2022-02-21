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
    }
}
