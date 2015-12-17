using Svg;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace jimney
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string resourceName = "jimney.Resources.Shapes.svg";
            using (Stream readStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
            {
                SvgDocument svgDocument = SvgDocument.Open<SvgDocument>(readStream);
                //BitmapImage bitmapImage = new BitmapImage();
                //MemoryStream writeStream = new MemoryStream();

                //svgDocument.Draw().Save(writeStream, ImageFormat.Png);
                //writeStream.Seek(0, SeekOrigin.Begin);
                //bitmapImage.BeginInit();
                //bitmapImage.StreamSource = writeStream;
                //bitmapImage.EndInit();

                svgImage.Width = (int)svgDocument.Width;
                svgImage.Height = (int)svgDocument.Height;
                svgImage.SvgDocument = svgDocument;
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                Close();
            }
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
