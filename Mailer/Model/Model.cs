using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Diagnostics;
using System.Linq;

namespace Mailer
{


    public class Accounts
    {
        static List<Account> accounts = new List<Account>()
        {
              new Account("root", "root"),
              new Account("login","password"),
              new Account("admin","admin")
        };

        static public bool Find(Account account)
        {
            foreach (Account acc in Accounts.accounts)
                if (acc.Login == account.Login && acc.Password == account.Password) return true;
            return false;
        }

        public static void Add(Account account)
        {
            accounts.Add(new Account(account.Login,account.Password));
        }

        static public List<string> GetAccounts
        {
            get
            {
                return (from element in accounts select element.Login+" "+element.Password).ToList();
                
            }
        }



    }


    public class Account : INotifyPropertyChanged
    {
        public Account()
        {
            Debug.WriteLine("Acount created");
        }
        public Account(string login,string password)
        {
            this.Login = login;
            this.Password = password;
            Debug.WriteLine("Acount created");
        }
        private string login;
        private string password;

        //Add something

        //Add something2

        //Lesson2
        static int Counter { get; set; } = 0;

        public string Login
        {
            get => login; set
            {

                if (value != login)
                {
                    login = value;
                    System.Diagnostics.Debug.WriteLine("Login sets");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Login"));
                }
            }
        }

        public string Password { get => password; set
            {
                
                if (value != password)
                {
                    password = value;
                    System.Diagnostics.Debug.WriteLine("Password sets");
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Password"));
                }
            }
        }


        #region Comment
        //public int Value1
        //{
        //    get
        //    {
        //        return value1;
        //    }
        //    set
        //    {
        //        System.Diagnostics.Debug.WriteLine("Value1 is changed!");
        //        if (value1 != value)
        //        {
        //            value1 = value;
        //            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Value1"));
        //        }
        //    }
        //}
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
    }


}
