using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTextConverters
{
    public class NumberTextConverter
    {
        static  Dictionary<int, string> numbersText = new Dictionary<int, string>();

        static NumberTextConverter()
        {
            numbersText.Add(0, "Zero");
            numbersText.Add(1, "One");
            numbersText.Add(2, "Two");
            numbersText.Add(3, "Three");
            numbersText.Add(4, "Four");
            numbersText.Add(5, "Five");
            numbersText.Add(6, "Six");
            numbersText.Add(7, "Seven");
            numbersText.Add(8, "Eight");
            numbersText.Add(9, "Nine");
        }
        public string ConvertToText(int number)
        {
            string numberText = string.Empty;

            numberText = numbersText[number];

            return numberText;
        }
    }
}
