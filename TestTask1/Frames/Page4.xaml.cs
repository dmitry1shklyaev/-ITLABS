using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
using System.Windows.Threading;

namespace TestTask1.Frames
{
    /// <summary>
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        private readonly DispatcherTimer timer;
        public Page4()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(20);
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();

            Classes.FrameSingleton.getFrame().Navigate(new Page1());
        }

        private void pdfViewIWT_Click(object sender, RoutedEventArgs e)
        {
            string pdfFilePath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "PDFs", "testPDF_IWT.pdf");

            if (File.Exists(pdfFilePath))
            {
                Process.Start(new ProcessStartInfo(pdfFilePath) { UseShellExecute = true });
            }
            else
            {
                MessageBox.Show("Файл PDF не найден.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void pdfViewRED_Click(object sender, RoutedEventArgs e)
        {
            string pdfFilePath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "PDFs", "testPDF_RED.pdf");

            if (File.Exists(pdfFilePath))
            {
                Process.Start(new ProcessStartInfo(pdfFilePath) { UseShellExecute = true });
            }
            else
            {
                MessageBox.Show("Файл PDF не найден.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
