using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB___GROEP_B
{
    class RGB
    {
        public byte R { get; set; } //byte - 0-255
        public byte G { get; set; }
        public byte B { get; set; }

        public RGB(byte r=0, byte g=0, byte b=0)
        {
            R = r;
            G = g;
            B = b;
        }
        /*public RGB()
        {
            R = 0; 
            G = 0;
            B = 0;
        } --> default constructor is ook optie*/

        static public RGB Random()
        {
            Random rd = new Random();
            //manier 1
            //RGB rgb = new RGB((byte)rd.Next(0, 256), (byte)rd.Next(0, 256), (byte)rd.Next(0, 256));
            //return rgb
            
            //manier 2
            //RGB rgb = new RGB()
            //rgb.R = (byte)rd.Next(0, 256);
            //rgb.G = (byte)rd.Next(0, 256);
            //rgb.B = (byte)rd.Next(0, 256);
            //return rgb

            //manier 3
            return new RGB((byte)rd.Next(0, 256), (byte)rd.Next(0, 256), (byte)rd.Next(0, 256));
        }

        //GreyScale() : returns the greyscale of the RGB-color according to his formula grey value
        //= 30% of red + 59% of green + 11% of blue
        public RGB Grey()
        {
            return new RGB((byte)(this.R * 0.3), (byte)(G * 0.59), (byte)(0.11 * B));
        }


        //Inverse() : returns the inverse color back by replacing each component with
        //255 minus that component.
        public RGB Inverse()
        {
            return new RGB((byte)(255 - R), (byte)(255 - G), (byte)(255 - B));
        }

        //ToString(): overwrite the ToString method, output RGB (r,g,b)
        public override string ToString()
        {
            return $"RGB ({R},{G},{B})";
        }
    }
}
