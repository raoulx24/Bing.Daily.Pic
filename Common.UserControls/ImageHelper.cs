using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomUserControls
{
    public class ImageHelper
    {
        public static Image Resize(Image original, int desiredHeight)
        {
            float fixedHt = (float)desiredHeight;
            int destHeight, destWidth;
            float reqScale;


            if (original.Height > fixedHt)
            {
                destHeight = (int)fixedHt;
                destWidth = (int)(fixedHt / original.Height * original.Width);
                reqScale = destWidth / destHeight * 100;
            }
            else
            {
                destHeight = original.Height;
                destWidth = original.Width;
                reqScale = fixedHt / destHeight * 100;
            }

            Bitmap bmp = new Bitmap(destWidth, destHeight);
            bmp.SetResolution(original.HorizontalResolution, original.VerticalResolution);
            Graphics grPhoto = Graphics.FromImage(bmp);

            grPhoto.DrawImage(original,
                new Rectangle(0, 0, destWidth, destHeight),
                new Rectangle(0, 0, original.Width, original.Height),
                GraphicsUnit.Pixel);

            return bmp;

        }
    }
}
