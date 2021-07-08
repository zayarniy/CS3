using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Mailer
{
    public class Model:INotifyPropertyChanged
    {
      
        //Add something
    
        //Add something2

        //Lesson2
        static int Counter { get; set; } = 0;

        public string Login { get; set; }
        public string Password { get; set; }


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
