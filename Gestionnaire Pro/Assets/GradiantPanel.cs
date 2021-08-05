using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace Gestionnaire_Pro
{
    public class GradiantPanel:Panel
    {
        public Color topColor { get; set; }
        public Color lowerColor { get; set; }
        public float angle { get; set; }
       
        public  void PaintPanel(PaintEventArgs e)
        {
            System.Drawing.Drawing2D.LinearGradientBrush gradBrush;
            gradBrush =
              new System.Drawing.Drawing2D.LinearGradientBrush(new
              Point(0, 0), new Point(this.Width, this.Height),
              topColor, lowerColor);

            Bitmap bmp = new Bitmap(this.Width, this.Height);

            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(gradBrush, new Rectangle(0, 0,
                            this.Width, this.Height));
            this.BackgroundImage = bmp;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            /*
            LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle,topColor,lowerColor,angle);
            Graphics g = e.Graphics;
            g.FillRectangle(brush,this.ClientRectangle);
          
            base.OnPaint(e);*/
        }





    
    
    }
}
