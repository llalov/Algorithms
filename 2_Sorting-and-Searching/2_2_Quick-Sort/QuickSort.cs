using System;

public class QuickSort<T> where T : IComparable
{
    public static void Sort(T[] arr)
    {
        Sort(arr, 0, arr.Length - 1);
    }

    private static int Partition(T[] arr, int lo, int hi)
    {
        if (lo >= hi)
        {
            return lo;
        }

        int i = lo;
        int j = hi + 1;

        while (true)
        {
            while(IsLess(arr[++i], arr[lo]))
            {
                if (i == hi) break;
            }
            while (IsLess(arr[lo], arr[--j]))
            {
                if (j == lo) break;
            }
            if (i >= j) break;
            Swap(arr, i, j);
        }
        Swap(arr, lo, j);
        return j;
    }

    private static void Sort(T[] arr, int lo, int hi)
    {
        if (lo >= hi)
        {
            return;
        }

        int part = Partition(arr, lo, hi);
        Sort(arr, lo, part - 1);
        Sort(arr, part + 1, hi);
    }

    private static void Swap(T[] arr, int elIndex1, int elIndex2)
    {
        T element1 = arr[elIndex1];
        arr[elIndex1] = arr[elIndex2];
        arr[elIndex2] = element1;
    }

    private static bool IsLess(T a, T b)
    {
        return a.CompareTo(b) == 1 ? false : true;
    }
}
