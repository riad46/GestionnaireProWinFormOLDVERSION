using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Gestionnaire_Pro
{
    public static class ThemeColor
    {

        public static Color PrimaryColor { get; set; }
        public static Color SecondaryColor { get; set; }
        public static List<string> ColorList = new List<string>() { "#00b4d8",
                                                                    "#0b525b",
                                                                    "#740b4e",
                                                                    "#5E60CE",
                                                                    
                                                                    "#48BFE3",
                                                                    "#355070",
                                                                    "#E56BCF",
                                                                    "#EAAC8B",
                                                                    
                                                                    "#0b525b",
                                                                    
                                                                    "#b9929f",
                                                                    "#E2C2C6",
                                                                    "#321622",
                                                                    "#740B4E",
                                                                    "#F37521",
                                                                    "#A12059",
                                                                    "#126881",
                                                                    "#8BC240",
                                                                    "#364D5B",
                                                                    "#C7DC5B",
                                                                    "#0094BC",
                                                                    "#E4126B",
                                                                    "#43B76E",
                                                                    "#7BCFE9",
                                                                    "#B71C46"};
        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            //If correction factor is less than 0, darken color.
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //If correction factor is greater than zero, lighten color.
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }

            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }

    }
}
