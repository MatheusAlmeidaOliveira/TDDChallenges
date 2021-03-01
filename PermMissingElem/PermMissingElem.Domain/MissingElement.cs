using System;

namespace PermMissingElem.Domain
{
    public static class MissingElement
    {
        public static int FindsMissingElement(int[] array)
        {
            Array.Sort(array);
            if (array.Length == 0)
            {
                return 1;
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != i + 1)
                {
                    return i + 1;
                }

            }

            return array.Length + 1;
        }
    }
}