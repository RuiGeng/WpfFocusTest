using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfFocus
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

        private async void Row3TextBlock_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            ((UIElement)sender).Focus();
            if (TextBox.Text != "")
            {
                await Task.Delay(2000);
                ShowInformation();
            }

            e.Handled = true;
        }

        private void ShowInformation()
        {
            var focusedElement = FocusManager.GetFocusedElement(TheWindow) as FrameworkElement;

            TextBox.Text = focusedElement?.Name ?? "No Element In TheWindow Got Logical Focused";
            TextBox.AppendText(Environment.NewLine);
            TextBox.AppendText(((FrameworkElement)Keyboard.FocusedElement).Name);
            TextBox.AppendText(Environment.NewLine);
            TextBox.AppendText(Row3TextBlock.IsFocused.ToString());
            TextBox.AppendText(Environment.NewLine);
            TextBox.AppendText(Row2TextBlock.IsFocused.ToString());
            TextBox.AppendText(Environment.NewLine);
            TextBox.AppendText(Row1TextBlock.IsFocused.ToString());
            TextBox.AppendText(Environment.NewLine);
            TextBox.AppendText(Row0TextBlock.IsFocused.ToString());
            TextBox.AppendText(Environment.NewLine);
            TextBox.AppendText(Grid0Border.IsFocused.ToString());
        }

        private async void Row2TextBlock_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            ((UIElement)sender).Focus();
            if (TextBox.Text != "")
            {
                await Task.Delay(2000);
                ShowInformation();
            }

            e.Handled = true;
        }

        private async void Row1TextBlock_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            ((UIElement)sender).Focus();
            if (TextBox.Text != "")
            {
                await Task.Delay(2000);
                ShowInformation();
            }

            e.Handled = true;
        }

        private async void Row0TextBlock_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            ((UIElement)sender).Focus();
            if (TextBox.Text != "")
            {
                await Task.Delay(2000);
                ShowInformation();
            }

            e.Handled = true;
        }

        private void Grid0Border_OnGotFocus(object sender, RoutedEventArgs e)
        {
            TextBox.Text = "Grid0Border_OnGotFocus";
        }

        private void Grid0Border_OnLostFocus(object sender, RoutedEventArgs e)
        {
            TextBox.Text = "Grid0Border_OnLostFocus";
        }
    }
}