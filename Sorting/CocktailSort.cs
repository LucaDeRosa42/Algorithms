// Cocktail shaker sort (bidirectional bubble sort)
// Time Complexity:
// Best: O(n)
// Average: O(n²)
// Worst: O(n²)
// Space: O(1), stable

public class CocktailSort
{
    public static void Sort(int[] arr)
    {
        if (arr == null || arr.Length <= 1)
            return;

        int start = 0;
        int end = arr.Length - 1;
        bool swapped = true;

        while (swapped)
        {
            swapped = false;

            // left to right: push the max to the end
            for (int i = start; i < end; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    (arr[i], arr[i + 1]) = (arr[i + 1], arr[i]); // swap
                    swapped = true;
                }
            }

            if (!swapped)
                break; // already sorted

            end--;
            swapped = false;

            // right to left: push the min to the start
            for (int i = end; i > start; i--)
            {
                if (arr[i] < arr[i - 1])
                {
                    (arr[i], arr[i - 1]) = (arr[i - 1], arr[i]); // swap
                    swapped = true;
                }
            }

            start++;
        }
    }
}
