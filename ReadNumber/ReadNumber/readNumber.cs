using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ReadNumber
{
    public class readNumber 
    {

        public static List<string> ListThree(long a)
        {
            long tam = a;
            List<string> threeNum = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                string s1 = Convert.ToString(tam % 1000);
                if ((s1.Length % 3) > 0)
                {
                    for (int j = 0; j < (s1.Length % 3); j++)
                    {
                        s1 = "0" + s1;
                    }
                }

                threeNum.Add(s1);
                tam = tam / 1000;
                if (tam == 0)
                    break;
            }

            return threeNum;

        }

        public static string ReadLetter(char b)
        {

            string result = "";
            switch (b)
            {
                case '1':
                    result = "Một ";
                    break;
                case '2':
                    result = "Hai ";
                    break;
                case '3':
                    result = "Ba ";
                    break;
                case '4':
                    result = "Bốn ";
                    break;
                case '5':
                    result = "Năm ";
                    break;
                case '6':
                    result = "Sáu ";
                    break;
                case '7':
                    result = "Bảy ";
                    break;
                case '8':
                    result = "Tám ";
                    break;
                case '9':
                    result = "Chín ";
                    break;
            }
            return result;

        }

        public static string ReadOne(string a)
        {
            char b = Convert.ToChar(a);
            if (b == '0')
            {
                return "Không";
            }
            else
            {
                return ReadLetter(b);
            }
        }


        public static string ReadTwo(string a)
        {

            char dv = a[1];
            char chuc = a[0];
            string readDv = "";
            string readChuc = "";

            switch (dv)
            {
                case '1':
                    {
                        if (chuc >= '2')
                            readDv = "Mốt ";
                        else
                            readDv = "Một ";
                        break;
                    }
                case '4':
                    {
                        if (chuc <= '1')
                            readDv = "Bốn ";
                        else
                            readDv = "Tư ";
                        break;
                    }
                case '5':
                    readDv = "Lăm ";
                    break;
                default:
                    readDv = ReadLetter(dv);
                    break;
            }

            if (chuc == '1')
            {
                readChuc = "Mười ";
            }
            else
            {
                readChuc = ReadLetter(chuc) + "Mươi ";
            }

            return (readChuc + readDv);
        }

        public static string ReadThree(string a, string Choice)
        {

            string result = "";
            char dv = a[2];
            char chuc = a[1];
            char tram = a[0];
            char[] chars = new char[] { chuc, dv };
            string Two = new string(chars);


            switch (tram)
            {
                case '0':
                    switch (chuc)
                    {
                        case '0':
                            if (dv == '0')
                                result = "Không Trăm ";
                            else
                                result = "Không Trăm " + Choice + ReadLetter(dv);
                            break;
                        default:
                            result = "Không Trăm " + ReadTwo(Two);
                            break;
                    }
                    break;
                default:
                    switch (chuc)
                    {
                        case '0':
                            if (dv == '0')
                                result = ReadLetter(tram) + "Trăm ";
                            else
                                result = ReadLetter(tram) + "Trăm " + Choice + ReadLetter(dv);
                            break;

                        default:
                            result = ReadLetter(tram) + "Trăm " + ReadTwo(Two);
                            break;
                    }
                    break;

            }

            return result;
        }

        public static string ReadNumber(long number, string Choice)
        {
            string[] donvi = { " ", "Nghìn ", "Triệu ", "Tỷ ", "Nghìn Tỷ ", "Triệu Tỷ ", "Tỷ Tỷ " };
            string result = " ";
            List<string> listNumber = ListThree(number);
            int countList = listNumber.Count;
            for (int i = countList - 1; i >= 0; i--)
            {
                if (i == countList - 1)
                {
                    int firstThreeNumber = Convert.ToInt32(listNumber[i]);
                    string firstThreeString = Convert.ToString(firstThreeNumber);

                    if (firstThreeString.Length == 1)
                    {
                        result += ReadOne(firstThreeString) + donvi[i];


                    }
                    else if (firstThreeString.Length == 2)
                    {
                        result += ReadTwo(firstThreeString) + donvi[i];
                    }
                    else
                        result += ReadThree(listNumber[i], Choice) + donvi[i];

                }
                else
                    result += ReadThree(listNumber[i], Choice) + donvi[i];


            }

            return result;



        }

    }
}

