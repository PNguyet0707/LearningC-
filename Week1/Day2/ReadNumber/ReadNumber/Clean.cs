/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ReadNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Mời bạn nhập số ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Số ban đầu là " + num);
                ReadMoney(num);

            }


        }
        static void ReadMoney(int num)
        {
            string kq = "";
            int dong = num % 1000;
            int nghin = (num / 1000) % 1000;
            int trieu = (num / 1000000);
            /*Console.WriteLine(dong);
            Console.WriteLine(nghin);
            Console.WriteLine(trieu);
            Console.WriteLine(readNum(dong));
            Console.WriteLine(readNum(nghin));
            Console.WriteLine(readNum(trieu));*/ 
/*
            if(readNum(trieu)!="")
            {
                kq += readNum(trieu) + "Triệu";
            }
            if (readNum(nghin) != "")
            {
                kq += readNum(trieu) + "Nghìn";
            }
            if (readNum(dong) != "")
            {
                kq += readNum(trieu) + "Đồng";
            }

            Console.WriteLine("Viết bằng chữ: " + kq);
            Console.WriteLine();



        }

        static string readNum(int a)
        {
            //Console.WriteLine(a);
            // string kq1 = Convert.ToString(a);
            string kq1 = "";
            int dv = a % 10;
            int chuc = (a / 10) % 10;
            int tram = (a / 100);
            if (tram >= 0)
                kq1 += ChangeNum(tram) + "Trăm ";
            if (chuc == 0)
            {
                if (tram > 0 && dv > 0)
                {
                    kq1 += "Lẻ ";
                }
            }
            else if (chuc == 1)
            {
                kq1 += "Mười ";
            }
            else if (chuc > 1)
            {
                kq1 += ChangeNum(chuc) + "Mươi ";
            }
            if (dv == 1 && chuc > 1)
            {
                kq1 += "Mốt ";

            }
            else if (dv == 1 && chuc <= 1)
            {
                kq1 += "Một ";

            }
            else if (dv == 4 && chuc <= 1)
            {
                kq1 += "Bốn ";

            }
            else if (dv == 4 && chuc > 1)
            {
                kq1 += "Tư ";

            }
            else if (dv == 5 && chuc > 0)
            {
                kq1 += "Lăm ";

            }
            else if (dv > 1)
            {
                kq1 += ChangeNum(dv);

            }

            return kq1;
        }

        static string ChangeNum(int a)
        {
            string b = Convert.ToString(a);
            //Console.WriteLine(b);
            // Console.WriteLine(a.GetType());
            switch (b)
            {
                case "0":
                    b = "Không ";
                    return b;
                case "1":
                    b = "Một ";
                    break;
                case "2":
                    b = "Hai ";
                    return b;
                case "3":
                    b = "Ba ";
                    return b;
                case "4":
                    b = "Bốn ";
                    return b;
                case "5":
                    b = "Năm ";
                    return b;
                case "6":
                    b = "Sáu ";
                    return b;
                case "7":
                    b = "Bảy ";
                    return b;
                case "8":
                    b = "Tám ";
                    return b;
                case "9":
                    b = "Chín ";
                    return b;
            }
            return b;

        }
    }
}
*/