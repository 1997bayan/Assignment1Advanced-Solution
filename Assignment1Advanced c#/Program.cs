using System;

namespace Assignment1Advanced_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            int[] array = { 55, 57, 8 };
            Helper.optimizedBubbleSort(array);
            foreach (int i in array)
            {
                Console.WriteLine($"{i} ");
            }
            #endregion

            #region Q2
            Range<int> Range1 = new Range<int>(99, 33);

            bool isInRange = Range1.IsInRange(3);
            Console.WriteLine(isInRange);


            int length = (int)Range1.Length();
            Console.WriteLine(length);

            #endregion


        }
    }
}
