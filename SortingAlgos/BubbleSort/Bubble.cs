namespace SortingAlgos.BubbleSort;

public static class Bubble
{
    public static int[] Sort(int[] numbers)
    {
        var i = 0;
        var j = numbers.Length;
        
        while (j > 0)
        {
            if (i + 1 >= j)
            {
                i = 0;
                j--;
            }

            if (numbers[i] <= numbers[i + 1])
            {
                i++;
                continue;
            }

            (numbers[i], numbers[i + 1]) = (numbers[i + 1], numbers[i]);
            i++;
        }

        return numbers;
    }
}