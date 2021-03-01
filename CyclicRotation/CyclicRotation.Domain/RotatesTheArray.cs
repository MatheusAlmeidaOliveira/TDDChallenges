namespace CyclicRotation.Domain
{
    public class Rotation
    {
        public int[] RotatesTheArray(int[] array, int times)
        {
            for (int i = 0; i < times; i++)
            {
                int[] arrayCopy = (int[])array.Clone();
                for (int j = 0; j < array.Length; j++)
                {
                    if (j + 1 == array.Length)
                        array[0] = arrayCopy[j];
                    else
                        array[j + 1] = arrayCopy[j];
                }
            }
            return array;
        }
    }
}