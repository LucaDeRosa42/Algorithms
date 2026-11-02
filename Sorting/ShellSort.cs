// Shell sort (gap sequence n/2, n/4, ..., 1)
// Time Complexity:
// Best: O(n log n)
// Average: depends on the gap sequence
// Worst: O(n²)
// Space: O(1), not stable

public class ShellSort
{
    public static void Sort(int[] arr)
    {
        if (arr == null || arr.Length <= 1)
            return;

        int n = arr.Length;

        for (int gap = n / 2; gap > 0; gap /= 2)
        {
            // gapped insertion sort
            for (int i = gap; i < n; i++)
            {
                int temp = arr[i];
                int j = i;

                while (j >= gap && arr[j - gap] > temp)
                {
                    arr[j] = arr[j - gap];
                    j -= gap;
                }

                arr[j] = temp;
            }
        }
    }
}
