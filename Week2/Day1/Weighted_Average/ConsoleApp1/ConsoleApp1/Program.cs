using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InputEncoding = Encoding.Unicode;
            OutputEncoding = Encoding.Unicode;
            int[,] ds = new int[10, 3]
            {
                { 1,25000,0},
                { 2,30000,0},
                { 3,25000,0},
                { 4,20000,0},
                { 1,45000,0},
                { 2,30000,0},
                { 4,45000,0},
                { 2,30000,0},
                { 5,37000,0},
                { 1,35000,0},

            };
            TinhTien(ds);
            InDs(ds);
            WriteLine("Tổng số lượng "+ CountQuantity(ds));
            WriteLine("Tổng giá tiền = " + TongTien(ds));
            WriteLine("Giá trị trung bình là  " + WeightedAverage(ds));
        }
        private static void TinhTien(int[,]a)
        {
            int row = a.GetLength(0);
            int col = a.GetLength(1);
            for(int i = 0; i < row; i++)
            {
                a[i, 2] = a[i,0] * a[i,1];

            }
                
        }
        private static long TongTien(int[,] a)
        {
            long result = 0;
            int row = a.GetLength(0);
            for (int i = 0; i < row; i++)
            {
                a[i, 2] = a[i, 0] * a[i, 1];
                result  += a[i, 2];

            }
            return result;

        }
        private static int CountQuantity(int[,] a )
        {
            int count = 0;
            int row = a.GetLength(0);
            int col = a.GetLength(1);
            for (int i = 0; i < row; i++)
            {
                count += a[i, 0];

            }
            return count;
        }
        private static void InDs(int[,] a)
        {
            int row = a.GetLength(0);
            int col = a.GetLength(1);
            for (var i = 0; i < row; i++)
            {
                for (var j = 0; j < col; j++)
                {
                    Write(a[i, j]+ "  ");
                }
                WriteLine();
            }


        }
        private static double  WeightedAverage( int[,] a) 
        {
            double result = Convert.ToDouble(TongTien(a)/CountQuantity(a));
            return result;

        }
    }
}
