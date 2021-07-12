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
        

        public MainWindow()
        {
            InitializeComponent();
            //tbLog.Text = "";
            MailerHelper.Action += MailerHelper_Action;
           
        }

        private void TscTabSwitcher_btnPrevClick(object sender, RoutedEventArgs e)
        {
            if (tcTabControl.SelectedIndex == 0) tcTabControl.SelectedIndex = tcTabControl.Items.Count - 1;
            else
                tcTabControl.SelectedIndex--;
        }

        private void TscTabSwitcher_btnNextClick(object sender, RoutedEventArgs e)
        {
            if (tcTabControl.SelectedIndex == tcTabControl.Items.Count - 1) tcTabControl.SelectedIndex = 0;
            else tcTabControl.SelectedIndex++;
        }

        private void MailerHelper_Action(DateTime dateTime, string message)
        {
            //tbLog.Text += dateTime+":"+message + "\r\n";

        }

        private void miExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void btnSent_Click(object sender, RoutedEventArgs e)
        {
            //MailMessage mailMessage = new MailMessage(tbLogin.Text, tbTo.Text,"Test subject", tbText.Text);
            //MailerHelper.Sent(mailMessage, pbPassword.Password);
        }

        private void miAbout_Click(object sender, RoutedEventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void tscTabSwitcher_btnPrevClick2(object sender, RoutedEventArgs e)
        {
            if (tcTabControl.SelectedIndex == 0) tcTabControl.SelectedIndex = tcTabControl.Items.Count - 1;
            else
                tcTabControl.SelectedIndex--;
        }
    }
}
