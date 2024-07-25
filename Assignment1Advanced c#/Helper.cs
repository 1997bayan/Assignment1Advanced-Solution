using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Advanced_c_
{
    internal class Helper
    {

        #region Q1
        public static void SWAP<T>(ref T X, ref T Y)
        {
            T temp = X;
            X = Y;
            Y = temp;

        }
        public static void optimizedBubbleSort(int[] array)
        {

            bool Swapped;
            int n = array.Length;

            //Handle Null and small array
            if (array == null || n < 2) return;

            //for loop
            for (int i = 0; i < n; i++)
            {
                int K = array.Length - i - 1;
                Swapped = false;
                for (int j = 0; j < K; j++)
                {
                    if (array[j] > array[j + 1])
                    {

                        SWAP<int>(ref array[j], ref array[j + 1]);
                        Swapped = true;
                    }

                }
                if (!Swapped) { break; }
            }




        } 
        #endregion


    }
}
