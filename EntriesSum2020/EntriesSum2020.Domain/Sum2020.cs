namespace EntriesSum2020.Domain
{
    public static class Sum2020
    {
        public static int FindsTheNumbersThatSum2020AndReturnsTheirMultiplication(int[] array, int numbers)
        {
            if (numbers == 2)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length; j++)
                    {
                        if ((array[i] + array[j]) == 2020)
                        {
                            return array[i] * array[j];
                        }
                    }
                }
            }
            else if (numbers == 3)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length; j++)
                    {
                        for (int y = 0; y < array.Length; y++)
                        {
                            if ((array[i] + array[j] + array[y]) == 2020)
                            {
                                return array[i] * array[j] * array[y];
                            }
                        }
                    }
                }
            }

            return -1;
        }
    }
}
