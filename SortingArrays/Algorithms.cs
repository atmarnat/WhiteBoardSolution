using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    class Arrays
    { 
        int[] arr;
        //sets an array (with default parameters)
        public Arrays(int length = 10, int range = 10)
        {
            arr = RandIntArray(length, range);
        }
        //returns the array
        public int[] GetArray() { return arr; }
        //Generates a random array of a defined size with defined random integers
        public int[] RandIntArray(int n, int rand)
        {
            Random r = new Random();
            int[] ar = new int[n];

            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = r.Next(0, rand);
            }
            return ar;
        }
        //bubble sort
        public int[] BubbleSort()
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(arr, j, j + 1);
                    }
                }
            }
            return arr;
        }
        //heap sort
        public int[] HeapSort()
        {
            for (int i = (arr.Length -1) / 2; i >= 0; i--)
            {
                Heapify(arr, arr.Length, i);
            }
            for (int i = arr.Length - 1; i > 0; i--)
            {
                Swap(arr, i, 0);
                Heapify(arr, i, 0);
            }
            return arr;
        }
        void Heapify(int[] a, int n, int i)
        {
            int root;
            int left = (i + 1) * 2 - 1;
            int right = (i + 1) * 2;
            root = left < n && a[left] > a[i] ? left : i;

            if(right < n && a[right] > a[root])
            {
                root = right;
            }
            if (root != i)
            {
                Swap(a, i, root);
                Heapify(a, n, root);
            }
        }
        //Insertion Sort
        public int[] InsertionSort()
        {
            int i = 1;
            while (i < arr.Length)
            {
                int j = i;
                while (j > 0 && arr[j - 1] > arr[j])
                {
                    Swap(arr, j, j - 1);
                    j--;
                }
                i++;
            }
            return arr;
        }
        //quicksort
        public int[] QuickSort()
        {
            return DoQuick(arr, arr[0], arr[arr.Length - 1]);
        }
        int[] DoQuick(int[] a, int low, int high)
        {
            if (low < high)
            {
                int p = Partition(a, low, high);
                DoQuick(a, low, p - 1);
                DoQuick(a, p + 1, high);
            }
            return a;
        }
        int Partition(int[] a, int low, int high)
        {
            int p = a[high];
            int i = low;
            for (int j = low; j < high-1; j++)
            {
                if (a[j] < p)
                {
                    Swap(a, a[i], a[j]);
                    i++;
                }
            }
            Swap(a, a[i], a[high]);
            return i;
        }
        //helper funtions
        int[] Swap(int[] array, int a, int b)
        {
            array[a] += array[b];
            array[b] = array[a] - arr[b];
            array[a] -= array[b];
            return array;
        }
    }
}
