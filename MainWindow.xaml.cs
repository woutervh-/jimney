using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
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

            string resourceName = "jimney.Resources.Shapes.xaml";
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                string content = reader.ReadToEnd().Replace("whiteSpaceCollapse=\"preserve\"", "xml:space=\"preserve\"");
                byte[] contentBytes = Encoding.UTF8.GetBytes(content);
                using (Stream contentStream = new MemoryStream(contentBytes))
                {
                    var shapes = XamlReader.Load(contentStream);
                }
            }
        }
    }
}
