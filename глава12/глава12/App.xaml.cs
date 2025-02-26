using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace WpfApp
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Обработка параметров командной строки
            if (e.Args.Length > 0)
            {
                MessageBox.Show("Запущено с параметром: " + e.Args[0]);
            }

            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            MessageBox.Show("Приложение завершается.");
            base.OnExit(e);
        }
    }
}
