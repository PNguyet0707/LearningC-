
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuNo_MotThamSo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            int[,] khachhang = new int[5,3]
            {
                {1,2,0},
                {11,5,0},
                {4,32,0},
                {40,6,0},
                {9,7,0}


            };
            InKhachHang(khachhang);
            Console.Write("Nhập đầu kỳ = ");
            int DauKy = Convert.ToInt32( Console.ReadLine());
            TinhSoDu(khachhang, DauKy);



        }

        private static void InKhachHang(int[,] kh)
        {
            int row = kh.GetLength(0);
            int col = kh.GetLength(1);
            for (int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    Console.Write("{0,-14}", kh[i, j] + "  ");

                }
                Console.WriteLine();
            }



        }
        private static void TinhSoDu(int[,] a, int DauKy)
        {
            
            var row = a.GetLength(0);
            for(int i = 0; i < row; i++)
            {
                a[i, 2] = DauKy + a[i, 0] - a[i, 1];
            }
            InKhachHang(a);
            
        }
    }
}
