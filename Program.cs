
void sort(int[] array)
{
    for (int i = array.Length / 2 - 1; i >= 0; i--)
    {
        heapify(array, array.Length, i);
    }

    for (int i = array.Length - 1; i >= 0; i--)
    {
        int temp = array[0];
        array[0] = array[i];
        array[i] = temp;

        heapify(array, i, 0);
    }
}

void heapify(int[] array, int heapSize, int rootIndex)
{
    int largest = rootIndex;
    int left = 2 * rootIndex + 1;
    int right = 2 * rootIndex + 2;

    if (left < heapSize && array[left] > array[largest])
    {
        largest = left;
    }

    if (right < heapSize && array[right] > array[largest])
    {
        largest = right;
    }

    if (largest != rootIndex)
    {
        int temp = array[rootIndex];
        array[rootIndex] = array[largest];
        array[largest] = temp;

        heapify(array, heapSize, largest);
    }
}


int[] arr = new int[100];

for (int i =0;i<arr.Length;i++)
{
    arr[i] = new Random().Next(0,1000);
}

System.Console.WriteLine($"{String.Join(",",arr)}");
System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine();
sort(arr);
System.Console.WriteLine($"{String.Join(",",arr)}");

