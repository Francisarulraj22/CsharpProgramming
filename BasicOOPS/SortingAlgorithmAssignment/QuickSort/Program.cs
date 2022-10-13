using System;
namespace QuickSort;
class program
{
        public static void QuickSort(int[] array, int left, int right) 
        {
            if (left < right)
            {
                int pivot = Partition(array, left, right);

                if (pivot > 1) {
                    QuickSort(array, left, pivot - 1);
                }
                if (pivot + 1 < right) {
                    QuickSort(array, pivot + 1, right);
                }
            }
        
        }
        public static int Partition(int[] array, int left, int right) 
        {
            int pivot = array[left];
            while (true) 
            {

                while (array[left] < pivot) 
                {
                    left++;
                }

                while (array[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (array[left] == array[right])
                    {
                        return right;
                    }

                    int tempvalue = array[left];
                    array[left] = array[right];
                    array[right] = tempvalue;
                }
                else 
                {
                    return right;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] array = new int[] {18,19,1,5,7,3,20};
            QuickSort(array, 0, array.Length-1);   
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }