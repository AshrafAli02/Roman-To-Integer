using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_To_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Numeral("CLX"));
        }
        public static int Numeral(string s)
        {
            int number = 0;
            for(int i=0;i<s.Length;i++)
            {
                if (i != s.Length - 1)
                {
                    if ((RomanToNumeral(s[i]) < RomanToNumeral(s[i+1])))
                    {
                        number += RomanToNumeral(s[i + 1]) - RomanToNumeral(s[i]);
                        i++;
                    }
                    else
                    {
                        number += RomanToNumeral(s[i]);
                    }
                }
                else
                {
                    number += RomanToNumeral(s[i]);
                }

            }
            return number;
        }
        public static int RomanToNumeral(char ch)
        {
            int Numeral = 0;
            int Roman = ch;
            switch(Roman)
            {
                case 73:
                    Numeral = 1;
                    break;
                case 86:
                    Numeral = 5;
                    break;
                case 88:
                    Numeral = 10;
                    break;
                case 76:
                    Numeral = 50;
                    break;
                case 67:
                    Numeral = 100;
                    break;
                case 68:
                    Numeral = 500;
                    break;
                case 77:
                    Numeral = 1000;
                    break;
            }
            return Numeral;
        }
    }   
}
