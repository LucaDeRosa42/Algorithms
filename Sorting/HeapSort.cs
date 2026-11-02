// Heap sort
// Time Complexity:
// Best: O(n log n)
// Average: O(n log n)
// Worst: O(n log n)
// Space: O(1), not stable

public class HeapSort
{
    public static void Sort(int[] arr)
    {
        if (arr == null || arr.Length <= 1)
            return;

        int n = arr.Length;

        // build a max heap
        for (int i = n / 2 - 1; i >= 0; i--)
            Heapify(arr, n, i);

        // move the max to the end and restore the heap on the rest
        for (int end = n - 1; end > 0; end--)
        {
            (arr[0], arr[end]) = (arr[end], arr[0]); // swap
            Heapify(arr, end, 0);
        }
    }

    static void Heapify(int[] arr, int size, int root)
    {
        while (true)
        {
            int largest = root;
            int left = 2 * root + 1;
            int right = 2 * root + 2;

            if (left < size && arr[left] > arr[largest])
                largest = left;
            if (right < size && arr[right] > arr[largest])
                largest = right;

            if (largest == root)
                return;

            (arr[root], arr[largest]) = (arr[largest], arr[root]); // swap
            root = largest;
        }
    }
}
