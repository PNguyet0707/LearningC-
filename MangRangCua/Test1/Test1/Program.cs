


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] arrCol2 = new int[3][];
            for (int j = 0; j < 3; j++)
            {
                arrCol2[j] = new int[3];
                
            }
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arrCol2[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}
