// Counting sort (good when the range of values k is small)
// Time Complexity:
// Best: O(n + k)
// Average: O(n + k)
// Worst: O(n + k)
// Space: O(n + k), stable

public class CountingSort
{
    public static void Sort(int[] arr)
    {
        if (arr == null || arr.Length <= 1)
            return;

        int min = arr.Min();
        int max = arr.Max();
        int[] count = new int[(long)max - min + 1];

        foreach (int value in arr)
            count[value - min]++;

        // prefix sums: count[i] = number of elements <= i + min
        for (int i = 1; i < count.Length; i++)
            count[i] += count[i - 1];

        // walk backwards to keep the sort stable
        int[] output = new int[arr.Length];
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            output[--count[arr[i] - min]] = arr[i];
        }

        Array.Copy(output, arr, arr.Length);
    }
}
