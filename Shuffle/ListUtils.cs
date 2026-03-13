using System;
using System.Collections.Generic;

static class ListUtils
{
    public static void Shuffle<T>(this IList<T> list)
    {

        Random random = new Random();
        for (int i = list.Count - 1; i >= 0; i--)
        {
            int newPosition = random.Next(0, i);

            T temp = list[newPosition];
            list[newPosition] = list[i];
            list[i] = temp;
        }
    }
}