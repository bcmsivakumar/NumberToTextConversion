﻿using System;
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
            numbersText.Add(10, "Ten");
            numbersText.Add(11, "Eleven");
            numbersText.Add(12, "Twelve");
            numbersText.Add(13, "Thirteen");
            numbersText.Add(14, "Fourteen");
            numbersText.Add(15, "Fifteen");
            numbersText.Add(16, "Sixteen");
            numbersText.Add(17, "Seventeen");
            numbersText.Add(18, "Eighteen");
            numbersText.Add(19, "Nineteen");

            numbersText.Add(20, "Twenty");
            numbersText.Add(30, "Thirty");
            numbersText.Add(40, "Fourty");
            numbersText.Add(50, "Fifty");
            numbersText.Add(60, "Sixty");
            numbersText.Add(70, "Seventy");
            numbersText.Add(80, "Eighty");
            numbersText.Add(90, "Ninety");
            numbersText.Add(100, "Hundred");
        }
        public string ConvertToText(int number)
        {
            string numberText = string.Empty;
            var numberString = number.ToString();
            Queue<int> numberCollection = new Queue<int>();

            if (numberString.Length == 2 && number > 20)
            {
                var charArray = numberString.ToCharArray();
                var twoDigitNumber = Convert.ToInt32(charArray[0].ToString() + "0");
                var singleDigitNumber = Convert.ToInt32(charArray[1].ToString());

                numberCollection.Enqueue(twoDigitNumber);
                if (singleDigitNumber > 0)
                {
                    numberCollection.Enqueue(singleDigitNumber);
                }
            }
            else
            {
                numberCollection.Enqueue(number);
            }

            foreach (var num in numberCollection)
            {
                numberText = numberText + " " + numbersText[num];
            }

            return numberText.Trim();
        }
    }
}
