namespace tasks;

public class Task1
{
    /**
     * Move all zeros to the end of the array.
     * Keep sorting.
     * Ex:
     * [ 0, 7, 3, 0, 1 ] -> [ 7, 3, 1, 0, 0 ]
     */
    public int[] toDo(int[] inputArray)
    {
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i] != 0) continue;
            bool hasSwap = false;
            for (int j = i + 1; j < inputArray.Length; j++)
            {
                if (inputArray[j] != 0)
                {
                    var tmp = inputArray[i];
                    inputArray[i] = inputArray[j];
                    inputArray[j] = tmp;
                    hasSwap = true;
                    break;
                }
            }
            if (!hasSwap) break;
        }
        return inputArray;
    }
}
