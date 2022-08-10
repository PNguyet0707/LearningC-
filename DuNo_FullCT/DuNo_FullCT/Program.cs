using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuNo_FullCT
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            int[,] khachhang = new int[2, 6];
            for (int i = 0; i < khachhang.GetLength(0); i++)
            {
                for (int j = 0; j < khachhang.GetLength(1) - 2; j++)
                {

                    Console.Write(" mời bạn nhập phần tử thứ " + j + " của khách hàng thứ " + i + " = ");
                    khachhang[i, j] = Convert.ToInt32(Console.ReadLine());
                    if (j == 0)
                    {
                        if (khachhang[i, j] != 0)
                        {
                            j++;
                        }
                    }

                }


            }

            for (int i = 0; i < khachhang.GetLength(0); i++)
            {
                int kq = khachhang[i, 0] - khachhang[i, 1] + khachhang[i, 2] - khachhang[i, 3];

                if (kq >= 0)
                {
                    khachhang[i, 4] = kq;

                }
                else
                {
                    khachhang[i, 5] = Math.Abs(kq);

                }

            }
            for (int i = 0; i < khachhang.GetLength(0); i++)
            {
                for (int j = 0; j < khachhang.GetLength(1); j++)
                {
                    Console.Write(khachhang[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        //    {
        //        Tinhsd();
        //        Console.ReadLine();
        //    }
        //}
        //private static void Tinhsd()
        //{
        //    int[][] ds = new int[3][];
        //    ds[0] = new int[] { 0, 0, 4, 11, 0, 0 };

        //    foreach (var row in ds)
        //    {
        //        if (row == null)
        //            continue;
        //        int kq = row[0] - row[1] + row[2] - row[3];
        //        if (kq > 0)
        //            row[4] = kq;
        //        else
        //            row[5] = -kq;
        //    }

        //    Inds(ds);
        //}

        //private static void Inds(int[][] ds)
        //{
        //    foreach (var row in ds)
        //    {
        //        Console.WriteLine("");
        //        if (row == null)
        //            continue;
        //        foreach (var item in row)
        //        {
        //            Console.Write("\t");
        //            Console.Write(item);
        //        }

        //    }

        //}

    }
}
    
    

