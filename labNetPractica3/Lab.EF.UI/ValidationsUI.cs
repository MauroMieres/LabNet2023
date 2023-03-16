using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.UI
{
    public static class ValidationsUI
    {
        public static bool IsValidPositiveInteger(string input)
        {
            if (int.TryParse(input, out int result) && result > 0)
            {
                return true;
            }
            return false;
        }

        public static bool ValidateLettersAndSpaces(string input)
        {
            foreach (char c in input)
            {
                if (!Char.IsLetter(c) && !Char.IsWhiteSpace(c))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool ValidateYesOrNo(string input)
        {
            if (input.ToUpper() == "S" || input.ToLower() == "N")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
