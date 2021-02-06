using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingSystemUI.Validation
{
    public static class Validator
    {
        public static void Validate(params string[] txbxs)
        {
            foreach (string txbx in txbxs)
            {
                if (string.IsNullOrEmpty(txbx))
                {
                    throw new ArgumentNullException();
                }
            }
        }

        public static sbyte IsAgeValueValid(string age, sbyte limit)
        {
            if (string.IsNullOrEmpty(age))
            {
                throw new ArgumentNullException("Age field is empty!");
            }
            if (!sbyte.TryParse(age, out sbyte result))
            {
                throw new FormatException();
            }
            if (sbyte.Parse(age) < limit)
            {
                throw new AgeValueValidException();
            }
            return result;
        }

        public static void IsEmailValid(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentNullException("Email field is empty!");
            }
                
            if (!email.Contains("@"))
            {
                throw new InvalidEmailException("Email must contains at(@)");
            }
        }

        public static void IsPasswordValid(string password)
        {
            if (string.IsNullOrEmpty(password))
                throw new ArgumentNullException();
            if (password.Length < 4)
                throw new InvalidPasswordException("Length of password must contains 4 or more characters");

        }
    }
}
