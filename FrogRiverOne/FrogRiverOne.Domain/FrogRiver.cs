namespace FrogRiverOne.Domain
{
    public static class FrogRiver
    {
        public static int FindsEarlistPosition(int time, int[] array)
        {
            int[] flags = new int[time + 1];
            int sum = 0;

            //Equivalent to all the leafs have fallen. 
            int desiredSum = (time * (time + 1)) / 2; // 1 + 2 + ....n = (n * (n + 1)) / 2

            for (int i = 0; i < array.Length; i++)
            {

                //Verify if the leaf [i] has fallen. 
                if (array[i] <= time && flags[array[i]] == 0)
                {
                    flags[array[i]] = 1;
                    sum += array[i];
                }

                //Verify if all the leafs have fallen.
                if (sum == desiredSum)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
