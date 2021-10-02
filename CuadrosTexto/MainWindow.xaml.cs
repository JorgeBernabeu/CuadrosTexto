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

namespace CuadrosTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            NombreTextBox.Tag = AyudaNombreTextBlock;
            ApellidoTextBox.Tag = AyudaApellidoTextBlock;
        }

        private void NombreYApellidoTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox texto = (TextBox)sender;

            TextBlock tagRecibido = (TextBlock)texto.Tag;

            if (e.Key == Key.F1 && tagRecibido.Visibility == Visibility.Hidden)
            {
                tagRecibido.Visibility = Visibility.Visible;

            }
            else if (e.Key == Key.F1 && tagRecibido.Visibility == Visibility.Visible)
            {
                tagRecibido.Visibility = Visibility.Hidden;
            }

        }

        private void EdadTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            bool parseable = int.TryParse(EdadTextBox.Text, out _);

            if(e.Key == Key.F2)
            {
                if(!parseable)
                {
                    ValidacionEdadTextBlock.Visibility = Visibility.Visible;
                }
                if(parseable)
                {
                    ValidacionEdadTextBlock.Visibility = Visibility.Hidden;
                }
            }
        }
    }
}
