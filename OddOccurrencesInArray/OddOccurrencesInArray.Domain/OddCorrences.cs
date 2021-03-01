using System.Linq;

namespace OddOccurrencesInArray.Domain
{
    public static class OddCorrences
    {
        public static int FindsUnpairedElement(int[] elements)
        {
            var unpaired = elements.ToList().GroupBy(x => x).Select(x => new { Key = x.Key, Value = x.Count() }).OrderByDescending(x => x.Value % 2).FirstOrDefault();
            return unpaired.Key;            
        }
    }
}