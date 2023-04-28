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

namespace Ejemplo_de_cambio_de_imagen_source
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Crea un nuevo bitmapimage para actulizar la imagen
            BitmapImage myBitmapImage = new();
            //Crea un uri
            Uri myUri = new Uri("C:\\Users\\TecNM-ITT\\source\\repos\\Ejemplo de cambio de imagen source\\Ejemplo de cambio de imagen source\\recursos\\waifu2.jpg");
            //Abre la inicializacion del bitmap
            myBitmapImage.BeginInit();
            //Le dice que es el uri que debe de cargar
            myBitmapImage.UriSource = myUri;
            //Cierra la carga
            myBitmapImage.EndInit();
            //Le dice que la iamgen waifu que esta en xaml se acrualice por ese bit map
            Waifu.Source = myBitmapImage;

        }
    }
}
