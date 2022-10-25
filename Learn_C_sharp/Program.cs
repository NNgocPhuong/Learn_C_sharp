using System;
using System.ComponentModel;
using System.Globalization;
using System.Numerics;

namespace Algorithm
{
 
    class myAlgorithm
    {
        int[] nums = new int[32];
        public int[] Nums
        {
            get { return nums; }
            set
            {
                for (int i = 0; i < n; i++)
                {
                    nums[i] = value[i];
                }
            }
        }
        int n;
        public int length
        {
            get { return n; }
            set { n = value; }
        }
        public void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b; b = temp;
        }
        public void bubleSort()
        {
            for(int i = 0; i < n-1; i++)
            {
                for(int j = n-1; j > i; j--)
                {
                    if(nums[j] < nums[j-1])
                    {
                        swap(ref nums[j], ref nums[j - 1]);
                    }
                }
            }
        }
        private int partition(int low, int high)
        {
            int left = low + 1;
            int right = high;
            int pivot = low;
            while (left <= right)
            {
                while (nums[pivot] > nums[left])
                {
                    left++;
                }
                while (nums[pivot] < nums[right])
                {
                    right--;
                }
                if (left <= right)
                {
                    swap(ref nums[left], ref nums[right]);
                    left++;
                    right--;
                }
            }
            swap(ref nums[pivot], ref nums[right]);
            return right;
        }
        private void spQuickSort(int[] data, int left, int right)
        {
            if (left < right)
            {
                int pi = partition(left, right);
                spQuickSort(data, left, pi-1);
                spQuickSort(data, pi + 1, right);
            }
        }
        public void quickSort()
        {
            spQuickSort(nums, 0, n - 1);
        }
        private void heapify(int i, int[] data, int size)
        {
            int max = i;
            int left = i * 2 + 1;
            int right = left + 1;
            if(data[max] < data[right] && right < size)
            {
                max = right;
            }
            if(data[max] < data[left] && left < size)
            {
                max = left;
            }
            if(max != i)
            {
                swap(ref data[max], ref data[i]);
                heapify(max, data, size);
            }

        }
        private void spHeapSort(int[] data, int size)
        {
            for (int i = size / 2 - 1; i >= 0; i--)
            {
                heapify(i, data, size);
            }
            for (int i = size-1; i >= 0; i--)
            {
                swap(ref data[i], ref data[0]);
                heapify(0,data, size);
            }
        }
        public void HeapSort()
        {
            spHeapSort(nums, n);
        }

        public void selectionSort()
        {
            for(int i = 0; i < n-1; i++)
            {
                int min_pos = i;
                for(int j = i+1; j < n; j++)
                {
                    if (nums[j] < nums[min_pos])
                        min_pos = j;
                }
                swap(ref nums[min_pos], ref nums[i]);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello world!");
            myAlgorithm A;
            A = new myAlgorithm();
            A.length = 5;
            int[] arr = { 2, 7, 5, 6, 1 };
            A.Nums = arr;
            //A.bubleSort();
            A.quickSort();
            //A.HeapSort();
            //A.selectionSort();
            for(int i = 0; i < A.length; i++)
            {
                Console.Write("\t" + A.Nums[i]);
            }
            Console.ReadKey();
        }
    }
}