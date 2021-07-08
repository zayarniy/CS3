using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net.Mail;

namespace Mailer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Model Model { get; } = new Model();

        public MainWindow()
        {
            InitializeComponent();
            tbLog.Text = "";
            MailerHelper.Action += MailerHelper_Action;
           
        }

        private void MailerHelper_Action(DateTime dateTime, string message)
        {
            tbLog.Text += dateTime+":"+message + "\r\n";

        }

        private void miExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void btnSent_Click(object sender, RoutedEventArgs e)
        {
            MailMessage mailMessage = new MailMessage(tbLogin.Text, tbTo.Text,"Test subject", tbText.Text);
            MailerHelper.Sent(mailMessage, pbPassword.Password);
        }

        private void miAbout_Click(object sender, RoutedEventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
    }
}
