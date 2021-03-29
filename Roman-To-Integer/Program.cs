using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_To_Integer
{
    class Program
    {
       public static Dictionary<char,int> MyDic=new Dictionary<char, int>();
        static void Main(string[] args)
        {
            DictioneryAdd();
            Console.WriteLine(Numeral("MMMM"));
        }
        public static int Numeral(string s)
        {
            int number = 0;
            for(int i=0;i<s.Length;i++)
            {
                if (i != s.Length - 1)
                {
                    if (MyDic[s[i]] < MyDic[s[i + 1]])
                    {
                        number += MyDic[s[i + 1]] - MyDic[s[i]];
                        i++;
                    }
                    else
                    {
                        number += MyDic[s[i]];
                    }
                }
                else
                {
                    number += MyDic[s[i]];
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

        public static void DictioneryAdd()
        {
            MyDic.Add('I',1);
            MyDic.Add('V', 5);
            MyDic.Add('X', 10);
            MyDic.Add('L', 50);
            MyDic.Add('C', 100);
            MyDic.Add('D', 500);
            MyDic.Add('M', 1000);
        }

    }   
}
