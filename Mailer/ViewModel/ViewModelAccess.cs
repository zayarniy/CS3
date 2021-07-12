using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace Mailer.ViewModel
{
    class ViewModelAccess: INotifyPropertyChanged
    {
        public Mailer.Account Account { get; set; } = new Account() { Login = "login", Password = "password" };


        public string Login
        {
            get
            {
                return Account.Login;
            }
            set
            {
                if (value!=Account.Login)
                {
                    Account.Login = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Login"));
                }
            }
        }

        public string Password
        {
            get
            {
                return Account.Password;
            }
            set
            {
                if (value != Account.Password)
                {
                    Account.Password = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Password"));
                }
            }
        }



        public List<string> ListAccounts
        {
            get
            {
                return Mailer.Accounts.GetAccounts;
            }
        }
        public ICommand ClickClear
        {
            get
            {
                DelegateCommand clear = new DelegateCommand(Clear,CanClear);
                return clear;
            }
        }

        public ICommand ClickLogin
        {
            get
            {
                DelegateCommand login = new DelegateCommand(LoginExecute, CanLogin);
                return login;
            }
        }

        public ICommand ClickAddAccount 
        { 
            get
            {
                DelegateCommand login = new DelegateCommand(AddAccountToList, CanLogin);
                return login;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void AddAccountToList(object o)
        {
            System.Diagnostics.Debug.WriteLine("Add account");

            Mailer.Accounts.Add(Account);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ListAccounts"));
        }
        private void LoginExecute(object o)
        {
            if (Mailer.Accounts.Find(Account))
                System.Diagnostics.Debug.WriteLine("Login");
            else
                System.Diagnostics.Debug.WriteLine("Access denied");
        }

        private bool CanLogin(object obj)
        {
            return !(Login == "" || Password == "");
        }
        private void Clear(object obj)
        {
            Login = "";
            Password = "";
        }

        private bool CanClear(object obj)
        {
            return !(Login == "" && Password == "");
        }



    }
}
