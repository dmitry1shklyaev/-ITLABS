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

namespace TestTask1.Frames
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void firstNumberTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(firstNumberTextBox.Text))
            {
                secondNumberTextBox.Focus();
            }
        }

        private void secondNumberTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(secondNumberTextBox.Text))
            {
                thirdNumberTextBox.Focus();
            }
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

        private void sendCodeAgain_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Код отправлен!");
        }

        private void confirmNumber_Button_Click(object sender, RoutedEventArgs e)
        {
            if(firstNumberTextBox.Text == "0" && secondNumberTextBox.Text == "0" && thirdNumberTextBox.Text == "0")
            {
                Classes.FrameSingleton.getFrame().Navigate(new Page4());
            }
            else
            {
                MessageBox.Show($"Код введён неправильно.\n\nПопробуйте ещё раз.");
            }
        }
    }
}
