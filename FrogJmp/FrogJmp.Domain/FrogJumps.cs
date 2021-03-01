namespace FrogJmp.Domain
{
    public static class FrogJumps
    {
        public static int MinimalNumberOfJumps(int currentPosition, int target, int jumpsDistance)
        {
            int minimalJumps = 0;
            while (currentPosition < target )
            {
                currentPosition += jumpsDistance;
                minimalJumps++; 
            }

            return minimalJumps;
        }
    }
}