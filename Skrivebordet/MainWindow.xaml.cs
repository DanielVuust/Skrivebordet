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
            UpdatePictures();
        }

        private void AddPicture(object sender, RoutedEventArgs e)
        {
            UploadPicture uploadPicture = new UploadPicture();
            uploadPicture.Upload(FilePath.Text);

        }
        
        private void UpdatePictures()
        {
            AllPictures pictures = new AllPictures();

            foreach (var picture in pictures.GetAllPictures())
            {
                BitmapImage src = new BitmapImage();
                Image i = new Image();

                src.BeginInit();
                src.UriSource = new Uri($"{picture}", UriKind.Relative);
                src.CacheOption = BitmapCacheOption.OnLoad;
                src.EndInit();

                i.Source = src;
                i.Stretch = Stretch.Uniform;

                i.Height = 200;
                i.Width = 200;
                
                ListPictures.Items.Add(i);
            }
        }

        private void ListPictures_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            
        }
    }
}
