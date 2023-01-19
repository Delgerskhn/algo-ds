using System;


internal class Program
{
    private static void Main(string[] args)
    {
        int n = 10;

        int[] array = new int[10] {
            16, 4, 10, 14, 7, 9, 3, 2, 8, 1
        };

        Console.WriteLine("Before max heapify:");
        Console.WriteLine(string.Join(" ", array));

        MaxHeapify(array, 1);

        Console.WriteLine("After max heapify:");
        Console.WriteLine(string.Join(" ", array));

        Console.WriteLine("Before build max heap:");
        Console.WriteLine(string.Join(" ", array));

        BuildMaxHeap(array);

        Console.WriteLine("After build max heap:");
        Console.WriteLine(string.Join(" ", array));
        // int[] arr1 = new int[14] {
        //     27, 17, 3, 16, 13, 10, 1, 5, 7, 12, 4, 8, 9, 0
        // };

        // Console.WriteLine("Before max heapify:");
        // Console.WriteLine(string.Join(" ", arr1));

        // MinHeapify(array, 0);

        // Console.WriteLine("After max heapify:");
        // Console.WriteLine(string.Join(" ", arr1));
    }

    private static void BuildMaxHeap(int[] arr)
    {

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            MaxHeapify(arr, i);
        }
    }


    private static void MinHeapify(int[] arr, int i)
    {
        int l = 2 * i + 1;
        int r = 2 * i + 2;
        int maxInd = i;

        if (l < arr.Length && -arr[l] > -arr[maxInd])
            maxInd = l;
        if (r < arr.Length && -arr[r] > -arr[maxInd])
            maxInd = r;

        if (i != maxInd)
        {
            int temp = arr[i];
            arr[i] = arr[maxInd];
            arr[maxInd] = temp;

            MinHeapify(arr, maxInd);
        }
    }

    private static void MaxHeapify(int[] arr, int i)
    {
        int l = 2 * i + 1;
        int r = 2 * i + 2;
        int maxInd = i;
        //zuun baruun uur gurvaasaa ali ihiih ni indexiig maxInd ruu hadgalna

        if (l < arr.Length && arr[l] > arr[maxInd])
            maxInd = l;

        if (r < arr.Length && arr[r] > arr[maxInd])
            maxInd = r;

        if (i != maxInd)
        {
            int temp = arr[i];
            arr[i] = arr[maxInd];
            arr[maxInd] = temp;

            MaxHeapify(arr, maxInd);
        }

    }
}