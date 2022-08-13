using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DuNo_DataTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTable dt = GetTable();
            dt.Rows.Add("D", 2, 4, 2, 2);
            //InDataTable(dt);
            // Đếm số dòng trong datatable 
            //Console.WriteLine(dt.Rows.Count);
            TinhSoDu(dt);


        }
        // Tạo 1 lấy 1 dataTable 
        // Nếu khai báo là public thay vì static thì có khác biệt gì
        private static  DataTable GetTable()
        {
            // Tạo 1 dataTable có tên là Tab
            // leKH từ class DataTable 
            DataTable TableKH  = new DataTable();
            // Add các cột cho bảng TableKh
            TableKH.Columns.Add("KhachHang", typeof(string));
            TableKH.Columns.Add("DauKyTang", typeof(int));
            TableKH.Columns.Add("DauKyGiam", typeof(int));
            TableKH.Columns.Add("TrongKyTang", typeof(int));
            TableKH.Columns.Add("TrongKyGiam", typeof(int));
            TableKH.Columns.Add("CuoiKyTang", typeof(int));
            TableKH.Columns.Add("CuoiKyGiam", typeof(int));

            //  Add các dòng dữ liệu cho bảng TableKH 
            TableKH.Rows.Add("A",3, 0, 2, 4);
            TableKH.Rows.Add("B",0,50, 4, 4);
            TableKH.Rows.Add("C",3, 0, 2, 24);

            // Return table 

            return TableKH;

        }
        private static void TinhSoDu( DataTable  a )
        {
            int kq = 0;
            foreach (DataRow row in a.Rows )
            {
               kq = Convert.ToInt32(row[1]) - Convert.ToInt32(row[2]) + Convert.ToInt32(row[3]) -Convert.ToInt32(row[4]);
               if (kq > 0)
                {
                   row[5] = kq;
                   row[6] = 0;
                }
               else
                {
                    row[5] = 0;
                    row[6] = -kq;
                }
                

            }
            InDataTable(a);


        }
        private static void InDataTable( DataTable dt )
        {
            foreach (DataColumn column in dt.Columns)
                Console.Write("{0,-14}", column.ColumnName + "  ");
            Console.WriteLine();
            foreach (DataRow row in dt.Rows)
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    Console.Write("{0,-14}", row[i] + "    ");
                }
                Console.WriteLine();

            }

        }
    }
}
