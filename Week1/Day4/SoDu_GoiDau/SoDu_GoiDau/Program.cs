using System;
using System.Data;
using System.Text;
using static System.Console;
namespace SoDu_GoiDau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InputEncoding = Encoding.UTF8;
            OutputEncoding = Encoding.UTF8;
            DataTable dt = GetTable();
            //dt.Rows.Add("D", 2, 4, 2, 2);
            //InDataTable(dt);
            // Đếm số dòng trong datatable 
            //Console.WriteLine(dt.Rows.Count);

            Write("Nhập đầu kỳ = ");
            int DauKy = Convert.ToInt32(ReadLine());
            TinhSoDu(dt,DauKy);


        }
        // Tạo 1 lấy 1 dataTable 
        // Nếu khai báo là public thay vì static thì có khác biệt gì
        private static DataTable GetTable()
        {
            // Tạo 1 dataTable có tên là Tab
            // leKH từ class DataTable 
            DataTable TableKH = new DataTable();
            // Add các cột cho bảng TableKh
            TableKH.Columns.Add("KhachHang", typeof(string));
            TableKH.Columns.Add("TrongKyTang", typeof(int));
            TableKH.Columns.Add("TrongKyGiam", typeof(int));
            TableKH.Columns.Add("CuoiKy", typeof(int));

            //  Add các dòng dữ liệu cho bảng TableKH 
            TableKH.Rows.Add("A", 3, 0);
            TableKH.Rows.Add("A", 3, 6);
            TableKH.Rows.Add("A",6 ,24);
            TableKH.Rows.Add("A", 12,10);
            TableKH.Rows.Add("A", 13, 7);
            TableKH.Rows.Add("A", 10, 9);

            // Return table 
            return TableKH;

        }

        private static void TinhSoDu(DataTable a, int DauKy )
        {
           
            int countRow = a.Rows.Count;
            for (int i = 0; i<countRow; i++)               
            {
                if (i == 0 )
                {
                    //a.Rows[i][3] =  Convert.ToInt32(a.Rows[i][1]) - Convert.ToInt32(a.Rows[i][2]);
                    a.Rows[i][3] = DauKy + Convert.ToInt32(a.Rows[i][1]) - Convert.ToInt32(a.Rows[i][2]);
                }
                else
                {
                     a.Rows[i][3] = Convert.ToInt32(a.Rows[i-1][3]) + Convert.ToInt32(a.Rows[i][1]) - Convert.ToInt32(a.Rows[i][2]);

                }
            }
            InDataTable(a);


        }
        private static void InDataTable(DataTable dt)
        {
            foreach (DataColumn column in dt.Columns)
                Write("{0,-14}", column.ColumnName + "  ");
            WriteLine();
            foreach (DataRow row in dt.Rows)
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    Write("{0,-14}", row[i] + "    ");
                }
                WriteLine();

            }

        }
    }

}

