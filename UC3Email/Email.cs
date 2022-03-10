using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UC3Email
{
    public class Email
    {
        public static string s = "^[a-zA-Z0-9]{3,20}@gmail.com$";

        public bool validateEmail(string name)
        {
            return Regex.IsMatch(name, s);
        }


    }
}
