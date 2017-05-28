using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataRomanNumerals
    {
        public KataRomanNumerals()
        {

        }

        public string ConvertToRomanNumeral(int n)
        {
            int temp;
            string romanNum = "";

            if(n == 0)
            {
                return "A true roman doesn't know the concept of zero";
            }

            if(n > 3000)
            {
                return "A true roman never counts past 3000";
            }

            if (n >= 1000)
            {
                
                temp = n / 1000;
                for (int i = 0; i < temp; i++)
                {
                    romanNum += "M";
                }

                if (temp == 4)
                {
                    romanNum = "CM";
                }

                n -= 1000 * temp;
                

            }

            if (n >= 100)
            {
                temp = n / 100;
                if (temp == 9)
                {
                    romanNum += "CM";
                }
                else if(temp == 4)
                {
                    romanNum += "CD";
                }
                else if (temp >= 5)
                {
                    
                    romanNum += "D";
                    for(int i = 0; i < temp - 5; i++)
                    {
                        romanNum += "C";
                    }
                }
                else
                {
                    for(var i = 0; i < temp; i++)
                    {
                        romanNum += "C";
                    }
                }

                n -= 100 * temp;
            }

            if(n >= 10)
            {
                temp = n / 10;
                
                if(temp == 9)
                {
                    romanNum += "XC";
                }
                else if(temp == 4)
                {
                    romanNum += "XL";
                }
                else if(temp >= 5)
                {
                    
                    romanNum += "L";
                    for (int i = 0; i < temp - 5; i++)
                    {
                        romanNum += "X";
                    }
                }
                else
                {
                    for (var i = 0; i < temp; i++)
                    {
                        romanNum += "X";
                    }
                }

                n -= 10 * temp;
            }

            if (n < 10)
            {

                if (n == 9)
                {
                    romanNum += "IX";
                }
                else if(n == 4)
                {
                    romanNum += "IV";
                }
                else if (n >= 5)
                {
                    n -= 5;
                    romanNum += "V";
                    for (int i = 0; i < n; i++)
                    {
                        romanNum += "I";
                    }
                }
                else
                {
                    for (var i = 0; i < n; i++)
                    {
                        romanNum += "I";
                    }
                }

                n = 0;
            }

            return romanNum;
        }

        public int ConvertToDigit(string romanNumeral)
        {
            int numeral = 0;

            if(romanNumeral.Contains("CM"))
            {
                numeral += 900;
                romanNumeral = romanNumeral.Remove(romanNumeral.IndexOf("CM"), 2);

            }
            if (romanNumeral.Contains("CD"))
            {
                numeral += 400;
                romanNumeral = romanNumeral.Remove(romanNumeral.IndexOf("CD"), 2);
            }
            if (romanNumeral.Contains("XC"))
            {
                numeral += 90;
                romanNumeral = romanNumeral.Remove(romanNumeral.IndexOf("XC"), 2);
            }
            if (romanNumeral.Contains("XL"))
            {
                numeral += 40;
                romanNumeral = romanNumeral.Remove(romanNumeral.IndexOf("XL"), 2);
            }
            if (romanNumeral.Contains("IX"))
            {
                numeral += 9;
                romanNumeral = romanNumeral.Remove(romanNumeral.IndexOf("IX"), 2);
            }
            if (romanNumeral.Contains("IV"))
            {
                numeral += 4;
                romanNumeral = romanNumeral.Remove(romanNumeral.IndexOf("IV"), 2);
            }


            foreach (char letter in romanNumeral)
            {
                switch(letter)
                {
                    case 'M':
                        numeral += 1000;
                        break;
                    case 'D':
                        numeral += 500;
                        break;
                    case 'C':
                        numeral += 100;
                        break;
                    case 'L':
                        numeral += 50;
                        break;
                    case 'X':
                        numeral += 10;
                        break;
                    case 'V':
                        numeral += 5;
                        break;
                    case 'I':
                        numeral += 1;
                        break;
                    default:
                        break;
                }
            }
            return numeral;
        }
    }
}
