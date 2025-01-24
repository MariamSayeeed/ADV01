using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV01
{
    internal class Range<T> where T: IComparable<T>
    {
        public T Minvalue { set; get; }
        public T Maxvalue { set; get; }
        public Range(T minValue , T maxValue) 
        { 
            if (minValue.CompareTo(maxValue) >0)
            {
                Console.WriteLine("Invalid,Min Value must be less than or equal to Max one");
                minValue = default;
                maxValue = default;
            }
            else
            {
                Minvalue = minValue;
                Maxvalue = maxValue;
            }

        }

        public bool IsInRange (T value)
        {
            if (value.CompareTo(Minvalue) >=0 && value.CompareTo(Maxvalue) <= 0)
                return true;
            return false;
        }


        public T Length()
        {
            if (typeof(T) == typeof(int))
            {
                int min = (int)(object)Minvalue;
                int max = (int)(object)Maxvalue;
                return (T)(object)(max - min);
            }
            else if (typeof(T) == typeof(double))
            {
                double min = (double)(object)Minvalue;
                double max = (double)(object)Maxvalue;
                return (T)(object)(max - min);
            }
            else if (typeof(T) == typeof(decimal))
            {
                decimal min = (decimal)(object)Minvalue;
                decimal max = (decimal)(object)Maxvalue;
                return (T)(object)(max - min);
            }
            else
            {
                throw new ("Type not known");
            }
        }


        public int CompareTo(T? other)
        {
            throw new NotImplementedException();
        }
    }
}
