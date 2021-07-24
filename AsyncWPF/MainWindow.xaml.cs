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

namespace AsyncWPF
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

        private void btnButton_Click(object sender, RoutedEventArgs e)
        {
            System.Threading.Thread.Sleep(10000);
        }

        private async void btnButton_Click2(object sender, RoutedEventArgs e)
        {
            await Task.Run(
                () =>
                {
                    for (int i = 0; i < 10; i++)
                    {
                        this.Dispatcher.Invoke(()=>tbText.Text = i.ToString());
                    System.Threading.Thread.Sleep(1000);
                    }
                }
                );
        }
    }
}
