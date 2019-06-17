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

namespace Zad3
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
        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            label1.Content = textBox1.Text;
        }
        private void RButton1_Checked(object sender, RoutedEventArgs e)
        {
            label1.HorizontalAlignment = HorizontalAlignment.Left;
        }
        private void RButton2_Checked(object sender, RoutedEventArgs e)
        {
            label1.HorizontalAlignment = HorizontalAlignment.Center;
        }
        private void RButton3_Checked(object sender, RoutedEventArgs e)
        {
            label1.HorizontalAlignment = HorizontalAlignment.Right;
        }
        private void RButton4_Checked(object sender, RoutedEventArgs e)
        {
            label1.HorizontalAlignment = HorizontalAlignment.Stretch;
        }
        private void RButton5_Checked(object sender, RoutedEventArgs e)
        {
            label1.VerticalAlignment = VerticalAlignment.Top;
        }
        private void RButton6_Checked(object sender, RoutedEventArgs e)
        {
            label1.VerticalAlignment = VerticalAlignment.Center;
        }
        private void RButton7_Checked(object sender, RoutedEventArgs e)
        {
            label1.VerticalAlignment = VerticalAlignment.Bottom;
        }
        private void RButton8_Checked(object sender, RoutedEventArgs e)
        {
            label1.VerticalAlignment = VerticalAlignment.Stretch;
        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            label1.HorizontalContentAlignment = HorizontalAlignment.Left;
        }
        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            label1.HorizontalContentAlignment = HorizontalAlignment.Center;
        }
        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            label1.HorizontalContentAlignment = HorizontalAlignment.Right;
        }
        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            label1.HorizontalContentAlignment = HorizontalAlignment.Stretch;
        }
        private void RadioButton_Checked_4(object sender, RoutedEventArgs e)
        {
            label1.VerticalContentAlignment = VerticalAlignment.Top;
        }
        private void RadioButton_Checked_5(object sender, RoutedEventArgs e)
        {
            label1.VerticalContentAlignment = VerticalAlignment.Center;
        }
        private void RadioButton_Checked_6(object sender, RoutedEventArgs e)
        {
            label1.VerticalContentAlignment = VerticalAlignment.Bottom;
        }
        private void RadioButton_Checked_7(object sender, RoutedEventArgs e)
        {
            label1.VerticalContentAlignment = VerticalAlignment.Stretch;
        }
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slider = sender as Slider;
            double value = slider.Value;
            Thickness T = new Thickness(value, value, value, value);
            label1.Margin = T;
        }
        private void Slider_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slider = sender as Slider;
            double value = slider.Value;
            Thickness T = new Thickness(value, value, value, value);
            label1.Padding = T;
        }
        private void Slider_ValueChanged_2(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slider = sender as Slider;
            double value = slider.Value;
            Color color = Color.FromRgb((byte)value, (byte)sliderG.Value, (byte)sliderB.Value);
            label1.Background = new SolidColorBrush(color);
        }
        private void Slider_ValueChanged_3(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slider = sender as Slider;
            double value = slider.Value;
            Color color = Color.FromRgb((byte)sliderR.Value, (byte)value, (byte)sliderB.Value);
            label1.Background = new SolidColorBrush(color);
        }
        private void Slider_ValueChanged_4(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slider = sender as Slider;
            double value = slider.Value;
            Color color = Color.FromRgb((byte)sliderR.Value, (byte)sliderG.Value, (byte)value);
            label1.Background = new SolidColorBrush(color);
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;
            int value = 0, teBox2 = 0, teBox3 = 0;
            if (textBox.Text == "") { value = 0; }
            else { value = int.Parse(textBox.Text); }
            if (tBox2.Text == "") { teBox2 = 0; }
            else { teBox2 = int.Parse(tBox2.Text); }
            if (tBox3.Text == "") { teBox3 = 0; }
            else {  teBox3 = int.Parse(tBox3.Text); }
            Color color = Color.FromRgb((byte)value, (byte)teBox2, (byte)teBox3);
            label1.Foreground = new SolidColorBrush(color);
        }
        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;
            int value = 0, teBox1 = 0, teBox3 = 0;
            if (textBox.Text == "") { value = 0; }
            else { value = int.Parse(textBox.Text); }
            if (tBox1.Text == "") { teBox1 = 0; }
            else { teBox1 = int.Parse(tBox1.Text); }
            if (tBox3.Text == "") { teBox3 = 0; }
            else { teBox3 = int.Parse(tBox3.Text); }
            Color color = Color.FromRgb((byte)teBox1, (byte)value, (byte)teBox3);
            label1.Foreground = new SolidColorBrush(color);
        }
        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;
            int value = 0, teBox2 = 0, teBox1 = 0;
            if (textBox.Text == "") { value = 0; }
            else { value = int.Parse(textBox.Text); }
            if (tBox2.Text == "") { teBox2 = 0; }
            else { teBox2 = int.Parse(tBox2.Text); }
            if (tBox1.Text == "") { teBox1 = 0; }
            else { teBox1 = int.Parse(tBox1.Text); }
            Color color = Color.FromRgb((byte)teBox1, (byte)teBox2, (byte)value);
            label1.Foreground = new SolidColorBrush(color);
        }
        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {
            FontFamily fFam = new FontFamily(tFam.Text);
            label1.FontFamily = fFam;
        }
        private void TextBox_TextChanged_4(object sender, TextChangedEventArgs e)
        {
            bool success = Int32.TryParse(tSize.Text, out int value);
            if (success)
            {
                label1.FontSize = (double)value;
            }
            else
            {
                label1.FontSize = 12;
            }
        }
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            label1.FontWeight = FontWeights.Bold;
        }
        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            label1.FontWeight = FontWeights.Normal;
        }
        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            label1.FontStyle = FontStyles.Italic;
        }
        private void CheckBox_Unchecked_1(object sender, RoutedEventArgs e)
        {
            label1.FontStyle = FontStyles.Normal;
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                Color col = (Color)ColorConverter.ConvertFromString(brush.Text);
                SolidColorBrush brush1 = new SolidColorBrush(col);
                label1.BorderBrush = brush1;
            }
            catch
            {
                return;
            }
        }
        private void ComboBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
            Color col = (Color)ColorConverter.ConvertFromString(brush.Text);
            SolidColorBrush brush1 = new SolidColorBrush(col);
            label1.BorderBrush = brush1;
            }
            catch
            {
                return;
            }
        }
        private void Slider_ValueChanged_5(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slider = sender as Slider;
            double value = slider.Value;
            Thickness T = new Thickness(value, value, value, value);
            label1.BorderThickness = T;
        }
    }
}
