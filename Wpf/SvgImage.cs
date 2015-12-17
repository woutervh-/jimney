using Svg;
using System;
using System.Drawing.Imaging;
using System.IO;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace jimney.Wpf
{
    class SvgImage : FrameworkElement, IDisposable
    {
        private MemoryStream stream = null;

        public SvgDocument SvgDocument
        {
            get;
            set;
        }

        public void Dispose()
        {
            if (stream != null)
            {
                stream.Close();
            }
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);

            if (SvgDocument != null)
            {
                if (stream != null)
                {
                    stream.Close();
                }

                stream = new MemoryStream();
                BitmapImage bitmapImage = new BitmapImage();
                SvgDocument.Draw().Save(stream, ImageFormat.Png);
                stream.Seek(0, SeekOrigin.Begin);
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = stream;
                bitmapImage.EndInit();
                drawingContext.DrawImage(bitmapImage, new Rect(0, 0, Width, Height));
            }
        }
    }
}
