using System;
using System.Drawing;
using Console = Colorful.Console;

namespace RGB___GROEP_B
{
    class Program
    {
        static void Main(string[] args)
        {
            RGB rgb = RGB.Random();
            Console.WriteLine(rgb.ToString(), Color.FromArgb(rgb.R, rgb.G, rgb.B));
            RGB grey = rgb.Grey();
            Console.WriteLine(grey.ToString(), Color.FromArgb(grey.R, grey.G, grey.B));
            RGB inverse = rgb.Inverse();
            Console.WriteLine(inverse.ToString(), Color.FromArgb(inverse.R, inverse.G, inverse.B));
        }
    }
}
