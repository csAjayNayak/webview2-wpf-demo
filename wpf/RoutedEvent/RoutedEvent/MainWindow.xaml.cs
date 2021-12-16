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

namespace RoutedEvent
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

        private void btnClickMe_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("I am the outer button");
        }

        private void outerEllliple_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //MessageBox.Show("I am the green ellipse");
            this.Title = "Green Ellipse !!";
        }

        private void InnerButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("I am the Inner button");
        }

        private void btnClickMe_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Mouse Moved by outter button");
        }

        private void InnerButton_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Mouse Moved by inner button");
        }
    }
}
