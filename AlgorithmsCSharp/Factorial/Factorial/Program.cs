using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Phím 0: Thoát khỏi chương trình.");
            Console.WriteLine("Bạn muốn làm gì nào ? \nHãy chọn 1 trong các chức năng sau :)) ");
            Console.WriteLine("Phím 1: Tính tổng các số tự nhiên đến số bạn nhập.");
            Console.WriteLine("Phím 2: Tính tích các số tự nhiên đến số bạn nhập.");
            Console.WriteLine("Phím 3: Kiểm tra số nguyên tố.");
            Console.WriteLine("Phím 4: Tìm ước chung lớn nhất giữa 2 số.");
            Console.WriteLine("Phím 5: Giải phương trình bậc 2.");




            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 0:
                    Console.WriteLine("Tạm biệt bạn!!");
                    break;
                case 1:
                    Tong();
                    break;
                case 2:
                    Tich();
                    break;
                case 3:
                    NguyenTo();
                    break;

                default :
                    Console.WriteLine("Nhập sai rồi bạn êi!!!");
                    break;
            }

            void Tong()
            {
                Console.WriteLine("Mời bạn nhập số muốn tính tổng");
                int n = Convert.ToInt32(Console.ReadLine());
                float result = 0;
                for (int i = 1; i <= n; i++)
                {
                    result += i;
                }
                Console.WriteLine("Tổng các số tự nhiên đến " + n + " =" + result);

            }

            void Tich()
            {
                Console.WriteLine("Mời bạn nhập số muốn tính tổng");
                int n = Convert.ToInt32(Console.ReadLine());
                float result = 1;
                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }
                Console.WriteLine("Tích các số tự nhiên đến " + n + " =" + result);

            }

            void NguyenTo()
            {
                Console.WriteLine("Mời bạn nhập số muốn kiểm tra ");
                int n = Convert.ToInt32(Console.ReadLine());
                bool check = false;
                for (int i = 2; i < n; i++)
                {
                    if(n%i==0)
                        check = true;
                }
                if (!check)
                    Console.WriteLine(n + " Là số nguyên tố");
                else
                    Console.WriteLine(n + " Không phải số nguyên tố ");
            }





        }


    }
    
}
