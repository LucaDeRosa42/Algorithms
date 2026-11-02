// Merge sort
// Time Complexity:
// Best: O(n log n)
// Average: O(n log n)
// Worst: O(n log n)
// Space: O(n), stable

public class MergeSort
{
    public static void Sort(int[] arr)
    {
        if (arr == null || arr.Length <= 1)
            return;

        int[] buffer = new int[arr.Length];
        Sort(arr, buffer, 0, arr.Length - 1);
    }

    static void Sort(int[] arr, int[] buffer, int left, int right)
    {
        if (left >= right)
            return;

        int mid = left + (right - left) / 2;
        Sort(arr, buffer, left, mid);
        Sort(arr, buffer, mid + 1, right);
        Merge(arr, buffer, left, mid, right);
    }

    static void Merge(int[] arr, int[] buffer, int left, int mid, int right)
    {
        int i = left;
        int j = mid + 1;
        int k = left;

        while (i <= mid && j <= right)
        {
            if (arr[i] <= arr[j])
                buffer[k++] = arr[i++];
            else
                buffer[k++] = arr[j++];
        }

        while (i <= mid)
            buffer[k++] = arr[i++];
        while (j <= right)
            buffer[k++] = arr[j++];

        Array.Copy(buffer, left, arr, left, right - left + 1);
    }
}
