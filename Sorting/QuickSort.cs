
class QuickSort
{
    static void Sort(int[] array, int left, int right)
    {
        if (left >= right)
            return;

        int pivot = array[(left + right) / 2];
        int index = Partition(array, left, right, pivot);
        Sort(array, left, index - 1);
        Sort(array, index, right);
    }

    static int Partition(int[] array, int left, int right, int pivot)
    {
        while (left <= right)
        {
            while (array[left] < pivot)
                left++;
            while (array[right] > pivot)
                right--;

            if (left <= right)
            {
                int temp = array[left];
                array[left] = array[right];
                array[right] = temp;
                left++;
                right--;
            }
        }

        return left;
    }

}
