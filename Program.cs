
using System;

namespace Program
{
    public class InsertionSort
    {
        public static void Main(string[] args)
        {
            var series = new int[] { 7, 3, 5, 8, 2, 9, 4, 15, 6 };
            var tempSeries = new int[series.Length];
            tempSeries[0] = series.FirstOrDefault();
            int counter = 0;
            while (counter + 1 < series.Length)
            {
                counter++;
                tempSeries[counter] = series[counter];
                for (int j = counter - 1; j >= 0; j--)
                {
                    if (tempSeries[j + 1] < tempSeries[j])
                    {
                        var temp = tempSeries[j + 1];
                        tempSeries[j + 1] = tempSeries[j];
                        tempSeries[j] = temp;
                    }
                }
            }
        }
    }
}