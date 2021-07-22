using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace Mailer.ViewModel
{
    class EMailValidationRule: ValidationRule
    {
        //fff.er3.tr45.q34@er234.43234.ewewee
        Regex regex = new Regex(@"^([a-z0-9_-]+\.)*[a-z0-9_-]+@[a-z0-9_-]+(\.[a-z0-9_-]+)*\.[a-z]{2,6}$");
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string adress = value.ToString();
            if (regex.IsMatch(adress)) 
                return 
                    new ValidationResult(true, null);
            else 
                return new ValidationResult(false, "Не является адресом");
            
        }
    }
}
