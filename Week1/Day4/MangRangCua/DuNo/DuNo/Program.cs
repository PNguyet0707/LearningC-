using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuNo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            int[,] KhachHang = new int[2, 6];
            for (int i = 0; i < KhachHang.GetLength(0);i++)
            { 
                for(int j=0; j<KhachHang.GetLength(1)- 2 ;j++)
                {
                    
                    Console.Write(" Mời bạn nhập phần tử thứ "+j+ " của khách hàng thứ "+ i +" = ");
                    KhachHang[i, j] = Convert.ToInt32(Console.ReadLine());
                    if(j==0 )
                    {
                        if (KhachHang[i,j] != 0 )
                        {
                            j ++ ;
                        }
                    }

                }


            }
            int InKy;
            for (int i = 0; i < KhachHang.GetLength(0); i++)
            {
                
                int kq = 0;
                InKy = KhachHang[i, 2] - KhachHang[i, 3];
             
                if(InKy >=0)
                {
                    if (KhachHang[i,0]>0)
                    {
                        KhachHang[i,4] = InKy + KhachHang[i,0];

                    }
                    else
                    {
                        kq = KhachHang[i, 1] - InKy;
                        if(kq >0)
                        {
                            KhachHang[i, 5] = kq;
                        }
                        else
                        {
                            KhachHang[i, 4] = Math.Abs(kq);
                        }
                    }

                }
                else
                {
                    if (KhachHang[i,1]>0)
                    {
                        KhachHang[i,5] = Math.Abs(InKy) + KhachHang[i,1];

                    }
                    else
                    {
                        kq = KhachHang[i, 0] + InKy;
                        if(kq >0)
                        {
                            KhachHang[i, 4] = kq;
                        }
                        else
                        {
                            KhachHang[i, 5] = Math.Abs(kq);
                        }
                    }
                }             



            }
            for (int i = 0; i < KhachHang.GetLength(0); i++)
            {
                for(int j = 0; j < KhachHang.GetLength(1); j++)
                {
                    Console.Write(KhachHang[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
