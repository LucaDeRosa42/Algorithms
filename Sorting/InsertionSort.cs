// Insertion sort
// Time Complexity:
// Best: O(n)
// Average: O(n²)
// Worst: O(n²)
// Space: O(1), stable

public class InsertionSort
{
    public static void Sort(int[] arr)
    {
        if (arr == null || arr.Length <= 1)
            return;

        for (int i = 1; i < arr.Length; i++)
        {
            int key = arr[i];
            int j = i - 1;

            // shift bigger elements one position to the right
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = key;
        }
    }
}
