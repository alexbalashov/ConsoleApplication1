using System.Drawing;

namespace ConsoleApplication1
{
    public class BaseClass
    {
        private Bitmap _image;

        public Bitmap Image
        {
            get { return _image; }
        }

        /// <summary>
        /// Remove Alpha channel
        /// </summary>
        public void RemoveAlphaChannel()
        {
            for (int i = 0; i < _image.Width; i++)
            {
                for (int j = 0; j < _image.Height; j++)
                {
                    var color = _image.GetPixel(i, j);

                    if (color.A!=255)
                    {
                        _image.SetPixel(i,j, Color.FromArgb(255,255,255,255));
                    }
                }
            }
        }
    }
}