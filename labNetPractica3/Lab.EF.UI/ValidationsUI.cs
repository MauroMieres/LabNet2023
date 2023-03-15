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

    }
}
