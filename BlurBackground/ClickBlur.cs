using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlurBackground
{
    class ClickBlur
    {
        PictureBox pb = new PictureBox();
        //var Panel1;

        private void Blur()
        {
            //Bitmap bmp = Screenshot.TakeSnapshot(Panel1);
            //BitmapFilter.GaussianBlur(bmp, 4);

            //pb.Image = bmp;
            //pb.BringToFront();
        }

        private void UnBlur()
        {
            pb.Image = null;
            pb.SendToBack();
        }
    }
}
