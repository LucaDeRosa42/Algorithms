// Radix sort (LSD, base 10, supports negative numbers)
// Time Complexity:
// Best: O(d * (n + b)), d = number of digits, b = base
// Average: O(d * (n + b))
// Worst: O(d * (n + b))
// Space: O(n + b), stable

public class RadixSort
{
    public static void Sort(int[] arr)
    {
        if (arr == null || arr.Length <= 1)
            return;

        // shift values so they are all non negative
        long min = arr.Min();
        long[] values = arr.Select(x => x - min).ToArray();
        long max = values.Max();

        long[] output = new long[values.Length];

        for (long exp = 1; max / exp > 0; exp *= 10)
        {
            int[] count = new int[10];

            foreach (long value in values)
                count[value / exp % 10]++;

            for (int i = 1; i < 10; i++)
                count[i] += count[i - 1];

            // walk backwards to keep each pass stable
            for (int i = values.Length - 1; i >= 0; i--)
                output[--count[values[i] / exp % 10]] = values[i];

            (values, output) = (output, values);
        }

        for (int i = 0; i < arr.Length; i++)
            arr[i] = (int)(values[i] + min);
    }
}
