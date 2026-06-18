// Gnome sort
// Time Complexity:
// Best: O(n)
// Average: O(n²)
// Worst: O(n²)

using System;

public static void Sort(int[] arr)
{
    if (arr == null || arr.Length <= 1)
        return;

    int i = 0;

    while (i < arr.Length)
    {
        if (i == 0 || arr[i] >= arr[i - 1])
        {
            i++;
        }
        else
        {
            (arr[i], arr[i - 1]) = (arr[i - 1], arr[i]); // swap 
            i--;
        }
    }
}

