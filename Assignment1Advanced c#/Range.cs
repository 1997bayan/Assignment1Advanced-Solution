using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Advanced_c_
{
    internal class Range<T> where T : IComparable<T>
    {


        //create a generic Range<T> class that represents a range of values from a minimum value to a maximum value.The range should support basic operations such as checking if a value is within the range and determining the length of the range.
        //        Requirements:
        //        Create a generic class named Range<T> where T represents the type of values.
        //        Implement a constructor that takes the minimum and maximum values to define the range.
        //        Implement a method IsInRange(T value) that returns true if the given  value is within the range, otherwise false.
        //        Implement a method Length() that returns the length of the range (the difference between the maximum and minimum values).
        //        Note: You can assume that the type T used in the Range<T> class implements the IComparable<T> interface to allow for comparisons.

       
        public T MaxValue { get; set; }
        public T MinValue { get; set; }
    

        public Range(T maxValue, T minValue)
        {
            if (minValue.CompareTo(maxValue) > 0)
            {
                throw new ArgumentException("MinValue should be less than the maxValue");
            }

            MaxValue = maxValue;
            MinValue = minValue;
        }
         //Example MinValue : 1 , MaxValue : 4; value : 2
        public  bool IsInRange (T value)
        {
            return value.CompareTo(MinValue) >= 0 && value.CompareTo(MaxValue) <= 0;
        }



        public int Length()
        {
            dynamic min = MinValue;
            dynamic max = MaxValue;
            int length = max - min;
            return length;

        }

    }
}
