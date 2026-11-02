// Bucket sort (good when values are uniformly distributed)
// Time Complexity:
// Best: O(n + k), k = number of buckets
// Average: O(n + k)
// Worst: O(n²)
// Space: O(n + k), stable

public class BucketSort
{
    public static void Sort(int[] arr)
    {
        if (arr == null || arr.Length <= 1)
            return;

        int min = arr.Min();
        int max = arr.Max();
        if (min == max)
            return;

        int bucketCount = arr.Length;
        var buckets = new List<int>[bucketCount];
        for (int i = 0; i < bucketCount; i++)
            buckets[i] = new List<int>();

        // distribute values into buckets by their position in [min, max]
        long range = (long)max - min + 1;
        foreach (int value in arr)
        {
            int index = (int)(((long)value - min) * bucketCount / range);
            buckets[index].Add(value);
        }

        // sort each bucket with insertion sort and concatenate
        int k = 0;
        foreach (var bucket in buckets)
        {
            for (int i = 1; i < bucket.Count; i++)
            {
                int key = bucket[i];
                int j = i - 1;
                while (j >= 0 && bucket[j] > key)
                {
                    bucket[j + 1] = bucket[j];
                    j--;
                }
                bucket[j + 1] = key;
            }

            foreach (int value in bucket)
                arr[k++] = value;
        }
    }
}
