using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Skrivebordet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddPicture(object sender, RoutedEventArgs e)
        {
            UploadPicture uploadPicture = new UploadPicture();
            uploadPicture.Upload(@"C:\Users\davu\OneDrive - cdm.dk\Billeder\Novartis (2).jpg");
        }
    }
}
