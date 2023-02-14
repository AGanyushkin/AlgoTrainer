namespace tasks;

using System;
using System.Text;

public class Task3
{
    /**
     * Return TRUE if two string is anagram each other
     * Ex: "aba" & "aab" -> true
     * Ex: "aba" & "abc" -> false
     */
    public bool toDo(string firstInputString, string secondInputString)
    {
        if (firstInputString == secondInputString) return true;
        if (firstInputString.Length != secondInputString.Length) return false;

        Dictionary<char, short> accumulator = new ();

        for (int i = 0; i < firstInputString.Length; i++)
        {
            char ch;

            ch = firstInputString[i];
            if (accumulator.ContainsKey(ch))
                accumulator[ch] += 1;
            else
                accumulator[ch] = 1;

            ch = secondInputString[i];
            if (accumulator.ContainsKey(ch))
                accumulator[ch] -= 1;
            else
                accumulator[ch] = -1;
        }

        foreach(var v in accumulator.Values)
        {
            if (v != 0) return false;
        }
        return true;
    }
}
