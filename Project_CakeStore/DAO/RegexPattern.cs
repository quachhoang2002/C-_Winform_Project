using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Project_CakeStore.DAO
{
    internal class RegexPattern
    {
        private Regex emailRegex = new Regex("(?<user>[^@]+)@(?<host>.+)");
        private Regex validatePhoneNumberRegex = new Regex("^\\+?[1-9][0-9]{7,14}$");

		public bool checkEmail(string Email)
		{
			return emailRegex.IsMatch(Email);
		}

		public bool checkPhoneNumber(string PhoneNumber)
		{
			return validatePhoneNumberRegex.IsMatch(PhoneNumber);
		}


	}
}
