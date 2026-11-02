// Jump search (requires a sorted array)
// Time Complexity:
// Best: O(1)
// Average: O(√n)
// Worst: O(√n)

public class JumpSearch
{
    public static int Search(int[] array, int target)
    {
        if (array == null)
            throw new ArgumentNullException(nameof(array));

        int n = array.Length;
        if (n == 0)
            return -1;

        int step = (int)Math.Sqrt(n);
        int prev = 0;

        // jump ahead in blocks until the block that may contain target
        while (array[Math.Min(step, n) - 1] < target)
        {
            prev = step;
            step += (int)Math.Sqrt(n);
            if (prev >= n)
                return -1;
        }

        // linear search inside the block
        for (int i = prev; i < Math.Min(step, n); i++)
        {
            if (array[i] == target)
                return i;
        }

        return -1;
    }
}
