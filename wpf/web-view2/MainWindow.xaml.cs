using Microsoft.Web.WebView2.Core;
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

namespace web_view2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            webView.WebMessageReceived += UpdateBtn2Text;
            InitializeAsync();
        }

        async void InitializeAsync()
        {
            await webView.EnsureCoreWebView2Async(null);
           // webView.WebMessageReceived += UpdateBtn2Text;

        }

        private void Native_To_Web_Click(object sender, RoutedEventArgs e)
        {
            webView.CoreWebView2.ExecuteScriptAsync("" + "document.getElementById('Resources').innerHTML = 'DPC'; ");
        }

        void UpdateBtn2Text(object sender, CoreWebView2WebMessageReceivedEventArgs args)
        {
            String text =  args.TryGetWebMessageAsString();
            Button2.Content = text;
        }
    }
}
