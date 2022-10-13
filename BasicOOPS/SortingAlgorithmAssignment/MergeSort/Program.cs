using System;
namespace MergeSort;
class program
{

    void merge(int[] array,int low,int high,int middle)
    {
        int size1=middle-low+1;
        int size2=high-middle;
        int[] Left=new int[size1];
        int[] Right=new int[size2];
        int i,j;

        for ( i = 0; i < size1; ++i)
        {
            Left[i]=array[low+i];
        }
        for (j = 0; j < size2; ++j)
        {
            Right[j]=array[middle+1+j];
        }

        j=0;
        i=0;
        int k=low;
        while (i<size1 && j<size2)
        {
            if (Left[i]<=Right[j])
            {
                array[k]=Left[i];
                i++;
            }
            else
            {
                array[k]=Right[j];
                j++;
            }
            k++;
        }
        while (i<size1)
        {
            array[k]=Left[i];
            i++;
            k++;
        }
        while (j<size2)
        {
            array[k]=Right[j];
            j++;
            k++;
        }
    }
    void sort(int[] array,int low,int high)
    {
        if(low<high)
        {
            int middle=low+(high-low)/2;
            sort(array,low,middle);
            sort(array,middle+1,high);
            merge(array,low,high,middle);
        }
    }
    static void Printarray(int[] array)
    {
        foreach (var item in array)
        {
            System.Console.WriteLine(item);
        }
    }
    public static void Main(string[] args)
    {
        int[] array={18,19,1,5,7,3,20};
        program sort=new program();
        sort.sort(array,0,array.Length-1);
        Printarray(array);
    }
}