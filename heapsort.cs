using System;

public class Heap
{

    private int[] arr;
    public int Size { get; private set; }
    public Heap(int[] arr)
    {
        this.arr = arr;
        this.Size = arr.Length;
    }
    public void BuildMaxHeap()
    {

        for (int i = Size - 1; i >= 0; i--)
        {
            MaxHeapify(i);
        }
    }


    public void MinHeapify(int i)
    {
        int l = 2 * i + 1;
        int r = 2 * i + 2;
        int maxInd = i;

        if (l < Size && -arr[l] > -arr[maxInd])
            maxInd = l;
        if (r < Size && -arr[r] > -arr[maxInd])
            maxInd = r;

        if (i != maxInd)
        {
            int temp = arr[i];
            arr[i] = arr[maxInd];
            arr[maxInd] = temp;

            MinHeapify(maxInd);
        }
    }

    public void MaxHeapify(int i)
    {
        int l = 2 * i + 1;
        int r = 2 * i + 2;
        int maxInd = i;
        //zuun baruun uur gurvaasaa ali ihiih ni indexiig maxInd ruu hadgalna

        if (l < Size && arr[l] > arr[maxInd])
            maxInd = l;

        if (r < Size && arr[r] > arr[maxInd])
            maxInd = r;

        if (i != maxInd)
        {
            int temp = arr[i];
            arr[i] = arr[maxInd];
            arr[maxInd] = temp;

            MaxHeapify(maxInd);
        }

    }

    public void HeapSort()
    {
        BuildMaxHeap();

        for (int i = arr.Length - 1; i > 0; i--)
        {
            Swap(0, i);
            Size--;
            MaxHeapify(0);
        }
    }

    private void Swap(int i, int j)
    {
        int temp = arr[j];
        arr[j] = arr[i];
        arr[i] = temp;
    }
    public void Print()
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = new int[10] {
            1,2,3,4,5,6,7,8,9,10
        };

        var heap = new Heap(array);
        Console.WriteLine("Before max heapify:");
        heap.Print();

        heap.MaxHeapify(0);

        Console.WriteLine("After max heapify:");
        heap.Print();

        Console.WriteLine("Before build max heap:");
        heap.Print();

        heap.BuildMaxHeap();

        Console.WriteLine("After build max heap:");
        heap.Print();


        Console.WriteLine("After heap sort:");
        heap.HeapSort();
        heap.Print();
        // int[] arr1 = new int[14] {
        //     27, 17, 3, 16, 13, 10, 1, 5, 7, 12, 4, 8, 9, 0
        // };

        // Console.WriteLine("Before max heapify:");
        // Console.WriteLine(string.Join(" ", arr1));

        // MinHeapify(array, 0);

        // Console.WriteLine("After max heapify:");
        // Console.WriteLine(string.Join(" ", arr1));
    }


}