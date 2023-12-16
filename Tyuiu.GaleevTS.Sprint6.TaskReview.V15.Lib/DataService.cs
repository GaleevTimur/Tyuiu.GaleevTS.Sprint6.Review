using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tyuiu.GaleevTS.Sprint6.TaskReview.V15.Lib
{
    public class DataService
    {
        public int[,] GetMatrix(int n, int m, int n1, int n2)
        {
            Random rand = new Random();
            int[,] array = new int[n, m];
            int count = 99999;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (n1 < n2)
                    {
                        if (j == 2 || j == count)
                        {
                            count = j + 3;
                            array[i, j] = (int)Math.Pow(array[i, j - 2], 2) - (int)Math.Pow(array[i, j - 1], 2);
                        }
                        else
                        {
                            array[i, j] = rand.Next(n1, n2 + 1);
                        }
                    }
                }
            }
            return array;
        }

        public int GetMult(int[,] array, int c, int k, int l)
        {
            var mult = 1;
            for (int i = k; i <= l; i++)
            {
                if (i % 2 != 0)
                {
                    mult = mult * array[i, c];
                }
                
            } 
            return mult;
        }
    }
}
