using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //    int[] arr = { 1, 0, 3, 4, -5, 6, 7 };//arrayimiz

            //// Unsorted array
            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    // Find minumu element in array
            //    int min_idx = i;
            //        for (int j = i + 1; j < arr.Length; j++)
            //        {
            //            if (arr[j] < arr[min_idx])
            //                min_idx = j;
            //            // Swap found minimum element to first
            //            int temp = arr[min_idx];
            //            arr[min_idx] = arr[i];
            //            arr[i] = temp;
            //        }
            //}Console.WriteLine(arr[0]);//Print first element because sorteder array first element is minumum 
            #endregion
            #region task 2
            string name = Console.ReadLine();//Input string
            char[] arr = name.ToCharArray();//Change array to char 
            bool hasA = false;
            foreach (char item in arr)//Check each letter 
            {
                if (item == 'a')
                {
                    hasA = true;
                    break;
                }
             
            }if (hasA) Console.WriteLine("A simbol have ");
            else Console.WriteLine("A simbol have not");
            #endregion
        }


    }
}