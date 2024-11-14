using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
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

        private void FIO_TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (FIO_TextBox.Text == "Фамилия, имя, отчество")
            {
                FIO_TextBox.Text = "";
                FIO_TextBox.Foreground = Brushes.White;
                FIO_TextBox.FontStyle = FontStyles.Normal;
            }
        }

        private void FIO_TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FIO_TextBox.Text))
            {
                FIO_TextBox.Text = "Фамилия, имя, отчество";
                FIO_TextBox.Foreground = Brushes.Gray;
                FIO_TextBox.FontStyle = FontStyles.Italic;
            }
        }

        private void numberTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (numberTextBox.Text == "Ваш телефон")
            {
                numberTextBox.Text = "";
                numberTextBox.Foreground = Brushes.White;
                numberTextBox.FontStyle = FontStyles.Normal;
            }
        }

        private void numberTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(numberTextBox.Text))
            {
                numberTextBox.Text = "Фамилия, имя, отчество";
                numberTextBox.Foreground = Brushes.Gray;
                numberTextBox.FontStyle = FontStyles.Italic;
            }
        }

        private void numberTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex(@"[^0-9+]");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void emailTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex(@"[^a-zA-Z0-9@.]");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void emailTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (emailTextBox.Text == "E-mail")
            {
                emailTextBox.Text = "";
                emailTextBox.Foreground = Brushes.White;
                emailTextBox.FontStyle = FontStyles.Normal;
            }
        }

        private void emailTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                emailTextBox.Text = "E-mail";
                emailTextBox.Foreground = Brushes.Gray;
                emailTextBox.FontStyle = FontStyles.Italic;
            }
        }

        private void FIO_TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex(@"[^a-zA-Zа-яА-Я-]");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void confirmData_Button_Click(object sender, RoutedEventArgs e)
        { 
            Classes.FrameSingleton.getFrame().Navigate(new Page3());
        }
    }
}
