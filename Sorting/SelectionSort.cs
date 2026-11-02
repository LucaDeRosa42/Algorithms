// Selection sort
// Time Complexity:
// Best: O(n²)
// Average: O(n²)
// Worst: O(n²)
// Space: O(1), not stable

public class SelectionSort
{
    public static void Sort(int[] arr)
    {
        if (arr == null || arr.Length <= 1)
            return;

        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            // find the smallest element in the unsorted part
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                    minIndex = j;
            }

            if (minIndex != i)
                (arr[i], arr[minIndex]) = (arr[minIndex], arr[i]); // swap
        }
    }
}
