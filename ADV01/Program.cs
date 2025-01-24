namespace ADV01
{
    internal class Program
    {

        #region Q1
        //public static void BubbleSort<T>(T[] array) where T : IComparable<T>
        //{

        //    // first, must check if it is already sorted or no sorting happens
        //    bool swapped;
        //    for (int i = 0; i < array.Length - 1; i++)
        //    {
        //        swapped = false;
        //        for (int j = 0; j < array.Length - 1 - i; j++)
        //        {
        //            if (array[j].CompareTo(array[j + 1]) > 0)
        //            {

        //                T temp = array[j];
        //                array[j] = array[j + 1];
        //                array[j + 1] = temp;
        //                swapped = true;
        //            }
        //        }

        //        if (!swapped)
        //            break;
        //    }
        //} 
        #endregion

        #region Q3
        //public static void ReverseArray<T>(T[] array)
        //{
        //    if (array == null || array.Length <= 1)
        //    {
        //        return;
        //    }

        //    int i = 0;
        //    int j = array.Length - 1;
        //    while (i <= j)
        //    {
        //        Console.Write($"{array[j]} ");
        //        j--;
        //    }

        //} 
        #endregion

        #region Q4
        //public static void checkEven(int[] list)
        //{
        //    int count = 0;
        //    for (int i = 0; i < list.Length; i++)
        //    {
        //        if (list[i] % 2 == 0)
        //        {
        //            count++;
        //        }
        //    }
        //    int[] newList = new int[count];
        //    int j = 0;
        //    for (int i = 0; i < list.Length; i++)
        //    {
        //        if (list[i] % 2 == 0)
        //        {
        //            newList[j] = list[i];
        //            j++;
        //        }
        //    }

        //    PrintArray(newList);
        //}

        //public static void PrintArray(int[] list)
        //{
        //    for (int i = 0; i < list.Length; i++)
        //    {
        //        Console.WriteLine($"{list[i]}");
        //    }
        //}
        #endregion

        #region Q6
        //public static int FirstRepated(string s)
        //  { 
        //      if (s == null || s.Length ==0)
        //      {
        //          return -1;
        //      }
        //      Dictionary<char,int> dict = new Dictionary<char,int>();
        //      foreach (char c in s)
        //      {
        //          if (dict.ContainsKey(c))
        //          {
        //              dict[c]++;
        //          }
        //          else
        //          {
        //              dict[c]= 1;
        //          }
        //      }

        //      for (int i = 0; i < s.Length; i++)
        //      {
        //          if (dict[s[i]] == 1)
        //          {
        //              return i;
        //          }
        //      }
        //      return - 1;

        //  }

        #endregion


        static void Main(string[] args)
        {
            #region Q2
            //Range<int> intRange = new Range<int>(10, 17);
            //Console.WriteLine($"Length of range: {intRange.Length()}");
            //// Output: 7

            //// -----------

            //Range<double> doubleRange = new Range<double>(10.5, 15.0);
            //Console.WriteLine($"Length of double range: {doubleRange.Length()}");
            //// Output 4.5
            //// -----------

            #endregion

            #region Q3
            //int[] intArray = { 1, 2, 3, 4, 5 };
            //Console.WriteLine("Original Array:");
            //Console.WriteLine("Reversed Array:");
            //ReverseArray(intArray);

            #endregion

            #region Q4
            //int[] intArray = { 1, 2, 3, 4, 5 };
            //checkEven(intArray);

            #endregion

            #region Q5
            //FixedSizeList<int> list = new FixedSizeList<int>(5);
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);

            //list.PrintArray();

            //Console.WriteLine($"Element in index 3: {list.Get(3)}"); //4
            //list.Add(6);
            //list.Get(7);

            #endregion

            #region Q6
            //string s = "accdrfau";
            //int index = FirstRepated(s);
            //Console.WriteLine($"The first non-repeated character is '{s[index]}' at index {index}");

            #endregion


        }

    }
}
