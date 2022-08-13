

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
//using ReadMoneyVietNamese

namespace PhanBo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InputEncoding = Encoding.UTF8;
            OutputEncoding = Encoding.UTF8;
            Write("Mời bạn nhập số lượng dòng = ");
            int row = Convert.ToInt32(ReadLine());
            Write("Mời bạn nhập số tổng tiền = ");
            double  Tien = Convert.ToDouble(ReadLine());

            double[,] PhanBo = new double[row, 3];
            NhapDuLieu(PhanBo);
            WriteLine();
            InDuLieu(PhanBo);
            WriteLine();
            TinhTien(PhanBo,Tien);



        }
        private static void NhapDuLieu(double[,] a)
        {
            int Row = a.GetLength(0);
            int Col = a.GetLength(1);
            for (int i = 0; i < Row; i++)
            {

                Write($"[{i},0] = ");
                a[i,0] = Convert.ToDouble(ReadLine());
            }

        }

        private static void InDuLieu(double[,]a)
        {
            int Row = a.GetLength(0);
            int Col = a.GetLength(1);
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Col; j++)
                {
                    Write(a[i,j] + "  ");
                }
               WriteLine();
            }
        }

        private static void TinhTien(double[,] a, double Tien)
        {
            double Tong = 0;
            int Row = a.GetLength(0);
            int Col = a.GetLength(1);
            // Tính tổng 
            for(int i = 0; i < Row; i++)
            {
                Tong = Tong + a[i,0];
            }
            // Tính hệ số của từng tầng
            double tam1 = 1;

            for (int i = 0; i < Row; i++)
            {

                if (i == Row - 1)
                {
                    a[i, 1] = tam1;
                }
                else
                {
                    a[i, 1] = Math.Round((a[i, 0] / Tong),10);
                    tam1 = tam1 - a[i, 1];
                }
                
            }


            double tam2 = Tien;


            for (int i = 0; i < Row; i++)
            {
                if (i == Row -1)
                {
                    a[i, 2] = tam2;
                }
                else
                { 
                    a[i, 2] = Math.Round((a[i, 1]*Tien),0);
                    tam2 = tam2 - a[i,2];
                }
            }
            InDuLieu(a);

        }
    }
}
