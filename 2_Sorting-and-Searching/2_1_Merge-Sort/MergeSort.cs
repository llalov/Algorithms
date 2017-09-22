using System;
using System.Collections.Generic;
using System.Text;

public class MergeSort<T> where T: IComparable
{
    private static T[] interimArr;

    public static void Sort(T[] arr)
    {
        interimArr = new T[arr.Length];
        Sort(arr, 0, arr.Length - 1);
    }

    private static void Merge(T[] arr, int lo, int mid, int hi)
    {
        if (IsLess(arr[mid], arr[mid + 1]))
        {
            return;
        }   

        //Copy elements from main array to interim array
        for (int index = lo; index < hi + 1; index++)
        {
            interimArr[index] = arr[index]; 
        }

        //Merge elements into main array
        int i = lo;
        int j = mid + 1;
        for (int k = lo; k <= hi; k++)
        {
            if (i > mid)
            {
                arr[k] = interimArr[j++];
            }
            else if (j > hi)
            {
                arr[k] = interimArr[i++];
            }
            else if (IsLess(interimArr[i], interimArr[j]))
            {
                arr[k] = interimArr[i++];
            }
            else
            {
                arr[k] = interimArr[j++];
            }
        }
    }

    private static void Sort(T[] arr, int lo, int hi)
    {
        //If there is only one element in the subarray its already sorted
        if (lo >= hi)
        {
            return;
        }

        int mid = (lo + hi) / 2;

        Sort(arr, lo, mid);
        Sort(arr, mid + 1, hi);
        Merge(arr, lo, mid, hi);
    }

    private static bool IsLess(T element1, T element2)
    {
        if (element1.CompareTo(element2) == 1)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
