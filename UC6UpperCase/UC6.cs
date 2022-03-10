﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;

namespace UC6UpperCase
{
    public class UC6
    {
        public static string s = "^[A-Z]{1}[a-z0-9]{7}$";
        public bool validateName(string name)
        {
            return Regex.IsMatch(name, s);
        }
    }
}
