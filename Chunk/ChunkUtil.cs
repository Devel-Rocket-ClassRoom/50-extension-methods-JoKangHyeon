using System;
using System.Collections.Generic;

static class ChunkUtil
{
    public static IEnumerable<IEnumerable<T>> Chunk<T>(this IEnumerable<T> source, int size)
    {
        if (size < 1)
        {
            throw new ArgumentException();
        }

        List<T> result = new();
        int count = 0;

        foreach (T item in source)
        {
            if (count == size)
            {
                yield return result;
                result = new();
                count = 0;
            }

            result.Add(item);
            count++;
        }

        yield return result;
    }
}