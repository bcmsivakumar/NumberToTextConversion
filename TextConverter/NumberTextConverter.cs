using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTextConverters
{
    public class NumberTextConverter
    {
        static  Dictionary<int, string> oneDigitText = new Dictionary<int, string>();
        static Dictionary<int, string> twoDigitText = new Dictionary<int, string>();
        static Dictionary<CurrencyType, string> currencyRealNumberText = new Dictionary<CurrencyType, string>();
        static Dictionary<CurrencyType, string> currencyPrecisionNumberText = new Dictionary<CurrencyType, string>();

        static NumberTextConverter()
        {
            oneDigitText.Add(0, "Zero");
            oneDigitText.Add(1, "One");
            oneDigitText.Add(2, "Two");
            oneDigitText.Add(3, "Three");
            oneDigitText.Add(4, "Four");
            oneDigitText.Add(5, "Five");
            oneDigitText.Add(6, "Six");
            oneDigitText.Add(7, "Seven");
            oneDigitText.Add(8, "Eight");
            oneDigitText.Add(9, "Nine");
            oneDigitText.Add(10, "Ten");
            oneDigitText.Add(11, "Eleven");
            oneDigitText.Add(12, "Twelve");
            oneDigitText.Add(13, "Thirteen");
            oneDigitText.Add(14, "Fourteen");
            oneDigitText.Add(15, "Fifteen");
            oneDigitText.Add(16, "Sixteen");
            oneDigitText.Add(17, "Seventeen");
            oneDigitText.Add(18, "Eighteen");
            oneDigitText.Add(19, "Nineteen");

            twoDigitText.Add(2, "Twenty");
            twoDigitText.Add(3, "Thirty");
            twoDigitText.Add(4, "Fourty");
            twoDigitText.Add(5, "Fifty");
            twoDigitText.Add(6, "Sixty");
            twoDigitText.Add(7, "Seventy");
            twoDigitText.Add(8, "Eighty");
            twoDigitText.Add(9, "Ninety");

            currencyRealNumberText.Add(CurrencyType.Dollar, "Dollar");
            currencyRealNumberText.Add(CurrencyType.Rupee, "Rupees");

            currencyPrecisionNumberText.Add(CurrencyType.Dollar, "Cent");
            currencyPrecisionNumberText.Add(CurrencyType.Rupee, "Paisa");
        }

        public string ConvertToText(long longNumber)
        {
            if (longNumber == 0)
                return oneDigitText[0];

            return ConvertToWord(longNumber);
        }

        public string CurrencyInWord(decimal number, CurrencyType currencyType = CurrencyType.Rupee)
        {
            if (number == 0)
                return oneDigitText[0];
            var parts = number.ToString().Split('.');
            var word = string.Empty;

            var realPart = ConvertToWord(Convert.ToInt64(parts[0])).Trim() + " " + currencyRealNumberText[currencyType].ToLower();
            var precisionPart = (parts.Length == 2 ? ("and " + ConvertToWord(Convert.ToInt64(parts[1].Substring(0, 2))).ToLower().Trim() + " " + currencyPrecisionNumberText[currencyType].ToLower()) : "");
            word = realPart + " " + precisionPart;

            return word.Trim();
        }

        public string ConvertToWord(long number, bool isRecursive=false)
        {
            string numberText = string.Empty;
            if (number < 0)
            {
                numberText = "Minus ";
                number = number * (-1);
            }

            if (number > 999999999999 && number <= 9999999999999999)
            {
                long temp = (long)(number / 1000000000000);

                if (temp > 19)
                {
                    numberText += ConvertToWord(temp, numberText.Length != 0) + " trillion ";
                }
                else
                {
                    var caseNumber = (numberText.Length == 0 ? oneDigitText[(int)temp] : oneDigitText[(int)temp].ToLower());
                    if (isRecursive)
                    {
                        caseNumber = caseNumber.ToLower();
                    }
                    numberText += caseNumber + " trillion ";
                }
                number = (number % 1000000000000);
            }

            if (number > 999999999 && number <= 999999999999)
            {
                int temp = (int)(number / 1000000000);
                if (temp > 19)
                {
                    numberText += ConvertToWord(temp, numberText.Length != 0) + " billion ";
                }
                else
                {
                    var caseNumber = (numberText.Length == 0 ? oneDigitText[temp] : oneDigitText[temp].ToLower());
                    if (isRecursive)
                    {
                        caseNumber = caseNumber.ToLower();
                    }
                    numberText += caseNumber + " billion ";
                }
                number = (int)(number % 1000000000);
            }

            if (number > 99999999 && number <= 999999999)
            {
                int temp = (int)(number / 10000000);
                if (temp > 19)
                {
                    numberText += ConvertToWord(temp, numberText.Length != 0) + " crore ";
                }
                else
                {
                    var caseNumber = (numberText.Length == 0 ? oneDigitText[temp] : oneDigitText[temp].ToLower());
                    if (isRecursive)
                    {
                        caseNumber = caseNumber.ToLower();
                    }
                    numberText += caseNumber + " crore ";
                }
                number = number % 10000000;
            }

            if (number > 9999999 && number <= 99999999)
            {
                int temp = (int)(number / 10000000);
                var caseNumber = (numberText.Length == 0 ? oneDigitText[temp] : oneDigitText[temp].ToLower());
                if (isRecursive)
                {
                    caseNumber = caseNumber.ToLower();
                }
                numberText += caseNumber + " crore ";
                number = number % 10000000;
            }

            if (number > 999999 && number <= 9999999 && numberText == string.Empty)
            {
                int temp = (int)(number / 1000000);
                var caseNumber = (numberText.Length == 0 ? oneDigitText[temp] : oneDigitText[temp].ToLower());
                if (isRecursive)
                {
                    caseNumber = caseNumber.ToLower();
                }
                numberText += caseNumber + " million ";
                number = number % 1000000;
            }
            else
            {
                if (number > 999999 && number <= 9999999)
                {
                    int temp = (int)(number / 100000);
                    numberText += ConvertToWord(temp, numberText.Length != 0) + (temp == 1 ? " lakh " : " lakhs ");
                    number = number % 100000;
                }

            }

            if (number > 99999 && number <= 999999)
            {
                int temp = (int)(number / 100000);
                numberText += ConvertToWord(temp, numberText.Length != 0) + (temp == 1 ? " lakh " : " lakhs ");
                number = number % 100000;
            }

            if (number > 9999 && number <= 99999)
            {
                int temp = (int)(number / 1000);
                numberText += ConvertToWord(temp, numberText.Length != 0) + " thousand ";
                number = number % 1000;
            }

            if (number > 999 && number <= 9999)
            {
                int temp = (int)number / 1000;
                var caseNumber = (numberText.Length == 0 ? oneDigitText[temp] : oneDigitText[temp].ToLower());
                if (isRecursive)
                {
                    caseNumber = caseNumber.ToLower();
                }
                numberText += caseNumber + " thousand ";
                number = number % 1000;
            }

            if (number > 99 && number <= 999)
            {
                int temp = (int)number / 100;
                var caseNumber = (numberText.Length == 0 ? oneDigitText[temp] : oneDigitText[temp].ToLower());
                if (isRecursive)
                {
                    caseNumber = caseNumber.ToLower();
                }
                numberText += caseNumber + " hundred ";
                number = number % 100;
            }

            if (number>=20 && number <= 99)
            {
                int temp = (int)number / 10;
                var caseNumber = numberText.Length == 0 ? twoDigitText[temp] : twoDigitText[temp].ToLower();
                if(isRecursive)
                {
                    caseNumber = caseNumber.ToLower();
                }
                numberText += (caseNumber) + " ";               
                number = number % 10;
            }

            if (numberText != null && number > 0)
            {
                if (number >= 0 && number < 20)
                {
                    var caseNumber = numberText.Length == 0 ? oneDigitText[(int)number] : oneDigitText[(int)number].ToLower();
                    if (isRecursive)
                    {
                        caseNumber = caseNumber.ToLower();
                    }
                    numberText += (caseNumber);
                }
            }
            
            return numberText.Trim();
        }        
    }   
}
