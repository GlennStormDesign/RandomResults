# Random Results

This small C# class library simply provides a series of pseudo-random result helper functions, including shuffle, weighted random, Gaussian random and a function to cycle results to avoid initial repetition.

## public static void CastRandomSeed(int rotations)
*This function cycles through pseudo-random values to avoid intial repetition, given the number of rotations to discard.*

## public static float FlatRandom(float min, float max)
*This function provides pseudo-random results with even (flat) distribution from given minimum and maximum values.*

## public static float WeightedRandom(float min, float max)
*This function provides pseudo-random results with a weighted distribution from given minimum and maximum values, closer to the minimum value.*

## public static float GaussianRandom(float min, float max)
*This function provides pseudo-random results with a Gaussian (bell curve) distribution from given minimum and maximum values, closer to the mid-point between minimum and maximum.*

## public static int[] ShuffleRandom(int size)
*This function provides shuffled (exhaustive random) integer values of a given size, from zero to the length of the size.*
