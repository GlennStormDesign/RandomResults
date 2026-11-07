using System;

public class RandomResults
{
    static Random current = new Random();

    /// <summary>
    /// Cycles through pseudo-random values to avoid intial repetition
    /// </summary>
    public static void CastRandomSeed(int rotations)
    {
        for (int i = 0; i < rotations; i++)
        {
            current.Next();
        }
    }

    /// <summary>
    /// Provides pseudo-random results with even (flat) distribution from given minimum and maximum values
    /// </summary>
    /// <param name="min">minimum value</param>
    /// <param name="max">maximum value</param>
    /// <returns>random result</returns>
    public static float FlatRandom(float min, float max)
    {
        return ((float)current.NextDouble() * (max - min)) + min;
    }

    /// <summary>
    /// Provides pseudo-random results with a weighted distribution from given minimum and maximum values, closer to the minimum value
    /// </summary>
    /// <param name="min">minimum value</param>
    /// <param name="max">maximum value</param>
    /// <returns>random result</returns>
    public static float WeightedRandom(float min, float max)
    {
        float top = (float)current.NextDouble() * (max - min);
        return ((float)current.NextDouble() * (top - min)) + min;
    }

    /// <summary>
    /// Provides pseudo-random results with a Gaussian (bell curve) distribution from given minimum and maximum values, closer to the mid-point between minimum and maximum
    /// </summary>
    /// <param name="min">minimum value</param>
    /// <param name="max">maximum value</param>
    /// <returns>random result</returns>
    public static float GaussianRandom(float min, float max)
    {
        float bottom = (float)current.NextDouble() * (max - min);
        float top = (float)current.NextDouble() * (max - min);
        if (bottom > top)
        {
            float tmp = bottom;
            bottom = top;
            top = tmp;
        }
        return ((float)current.NextDouble() * (top - bottom)) + bottom; ;
    }

    /// <summary>
    /// Provides shuffled (exhaustive random) integer values of a given size, from zero to the length of the size
    /// </summary>
    /// <param name="size">the number of shuffled values</param>
    /// <returns>shuffled integers</returns>
    public static int[] ShuffleRandom(int size)
    {
        if (size < 0)
            size = 0;
        int[] retInts = new int[size];        
        if (size > 0)
        {
            for (int i = 0; i < size; i++)
            {
                retInts[i] = -1;
            }
            int count = 0;
            while (count < size)
            {
                int tmp = current.Next(size+1);
                bool found = false;
                for (int i = 0; i < size; i++)
                {
                    if (retInts[i] == tmp)
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                    retInts[count++] = tmp;
            }
        }
        return retInts;
    }
}