using System;

namespace BinaryGap.Domain
{
    public class Gap
    {
        public int FindsTheBinaryGap(int value)
        {
            string binaryRep = Convert.ToString(value, 2);

            int maxGapSize = 0;
            int currGapSize = 0;

            foreach (char ch in binaryRep)
            {
                if (ch == '0')
                {
                    currGapSize++;
                }
                else
                {
                    maxGapSize = Math.Max(currGapSize, maxGapSize);
                    currGapSize = 0;
                }
            }

            return maxGapSize;
        }
    }
}