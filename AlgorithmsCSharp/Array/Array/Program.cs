using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            // Mảng một chiều ----------------------------------------------------
            /* 
              Console.Write(" Nhập số phần tử của mảng ");
              int n = Convert.ToInt32(Console.ReadLine());
              int[] arr1 = new int[n];
              for(int i = 0; i < n; i++)
              {
                  Console.Write("Mời bạn nhập phần tử thứ " + i + " ");
                  arr1[i] = Convert.ToInt32(Console.ReadLine());
              }
              foreach (int i in arr1)
              {
                  Console.WriteLine(i);
              }
            */
            // Mảng 2 chiều ------------------------------------------------------

            Console.Write("Mời bạn nhập số dòng của ma trận 1 ");
            int row1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mời bạn nhập số cột của ma trận 1 ");
            int col1 = Convert.ToInt32(Console.ReadLine());

            int[,] Mt1 = new int[row1, col1];
            NhapMaTran(Mt1);
            InMaTran(Mt1);
            

            Console.Write("Mời bạn nhập số dòng của ma trận 2 ");
            int row2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mời bạn nhập số cột của ma trận 2 ");
            int col2 = Convert.ToInt32(Console.ReadLine());
            int[,] Mt2 = new int[row2, col2];

            NhapMaTran(Mt2);
            InMaTran(Mt2);
            NhanMaTran(Mt1, Mt2);







            void NhapMaTran(int[,] a)
            {

                int row = a.GetLength(0);
                int col = a.GetLength(1);
                for (int i = 0; i < row; i++)
                    for (int j = 0; j < col; j++)
                    {
                        Console.Write("Mời bạn nhập phần tử [" + i + "," + j + "] = ");
                        a[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
            }
            void InMaTran(int[,] a)
            {
                int row = a.GetLength(0);
                int col = a.GetLength(1);
                Console.WriteLine("Ma trận có " + row + " dòng");
                Console.WriteLine("Ma trận có " + col + " cột");

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        Console.Write(a[i, j] + "  ");
                    }
                    Console.WriteLine();

                }
            }


            void NhanMaTran(int[,] M1, int[,] M2)
            {
                int Row1 = M1.GetLength(0);
                int Col1 = M1.GetLength(1);
                int Row2 = M2.GetLength(0);
                int Col2 = M2.GetLength(1);
                int[] A1 = new int[Row1];
                int[] A2 = new int[Col2];

                int[,] kq = new int[Row1, Col2];
                for (int i = 0; i < Row1; i++)
                    for (int j = 0; j < Col2; j++)
                    {
                        kq[i, j] = 0;
                    }
                if (Col1 != Row2)
                {
                    Console.WriteLine("Hai ma trận trên không thỏa điều kiện để nhân ma trận ");

                }
                else
                {
                    int[][] arrCol2 = new int[Col2][];
                    for (int i = 0; i < Col2; i++)
                    {
                        arrCol2[i] = new int[Row2];
                        for (int j = 0; j < Row2; j++)
                        {
                            arrCol2[i][j] = M2[j, i];
                        }
                    }

                    for(int i = 0; i < Row1; i++)
                    {
                        // Dòng thứ i của ma trận  1 
                        for(int j = 0; j < Col1; j++)
                        {
                            A1[j] = Mt1[i, j]; 
                        }
                        for (int n = 0; n < Col2; n++)
                        {
                            for (int m = 0; m < Row2; m++)
                            {
                                kq[i,n] = kq[i,n] + arrCol2[n][m] * A1[m];
                            }
                        }

                    }
                    Console.WriteLine(" Kết quả nhân 2 ma trận trên ");
                    InMaTran(kq);


                }

            }



        }

    }
}

