namespace tasks;

using System.Text;

public class Task2
{
    /**
     * Count number of 
     * Ex: "abbbnnnm" -> "a1b3n3m1"
     */
    public string toDo(string inputString)
    {
        if (inputString.Length == 0) return "";
        if (inputString.Length == 1) return $"{inputString}1";

        StringBuilder builder = new();
        char current = inputString[0];
        byte counter = 1;

        for(int i = 1; i < inputString.Length; i++)
        {
            if (inputString[i] != current)
            {
                builder
                    .Append(current)
                    .Append(counter);
                current = inputString[i];
                counter = 1;
            }
            else
            {
                counter += 1;
            }
        }
        builder
            .Append(current)
            .Append(counter);
        return builder.ToString();
    }
}
