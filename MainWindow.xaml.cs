using System;
using System.Collections.Generic;
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
using System.Windows.Markup;
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

            var resources = Assembly.GetExecutingAssembly().GetManifestResourceNames();

            string content = File.ReadAllText("Shapes2.xaml").Replace("whiteSpaceCollapse=\"preserve\"", "xml:space=\"preserve\"");
            using (Stream contentStream = new MemoryStream(Encoding.UTF8.GetBytes(content)))
            {
                // var shapes = XamlReader.Load(contentStream);
                var image = new Image();
                image.Source = new BitmapImage(new Uri(System.IO.Path.Combine(Environment.CurrentDirectory, "Shapes.png")));
                this.Content = image;
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
