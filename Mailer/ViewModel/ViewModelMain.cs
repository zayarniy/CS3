using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace Mailer.ViewModel
{
    class ViewModelMain: INotifyPropertyChanged
    {
        public Mail Mail { get; set; } = new Mail();
        public Database Database { get; set; } = new Database();

        public string MailTo { get => Mail.To;
            set
            {
                if (value != Mail.To)
                {
                    Mail.To = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MailTo"));

                }
                
            } }

        public ObservableCollection<string> DataBaseListTo { get => Database.ListTo; }

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand SendAtOnce
        {
            get
            {
                return new DelegateCommand((o) =>
                {
                    System.Threading.Thread thread = new System.Threading.Thread(() =>
                      {
                          System.Threading.Thread.Sleep(5000);
                          System.Diagnostics.Debug.WriteLine("Mail is sent");
                      });
                    thread.Start();

                },

                (o)=>true);
            }
        }
    }
}
