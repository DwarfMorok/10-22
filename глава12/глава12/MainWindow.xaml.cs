using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Загрузка изображения из GitHub
            var imageUrl = "https://raw.githubusercontent.com/DwarfMorok/JoJoJo/main/JoJo.jpg";
            var bitmap = new BitmapImage(new Uri(imageUrl));
            ImageControl.Source = bitmap;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Закрытие приложения через класс Application
            Application.Current.Shutdown();
        }
    }
}