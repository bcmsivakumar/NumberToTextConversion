using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTextConverters
{
    public class NumberTextConverter
    {
        public string ConvertToText(int number)
        {
            string numberText = string.Empty;

            if (number == 0)
                numberText = "Zero";
            if (number == 1)
                numberText = "One";

            return numberText;
        }
    }
}
