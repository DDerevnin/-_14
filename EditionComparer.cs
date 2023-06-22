using System.Collections.Generic;

namespace Homework12
{
    public class EditionComparer : IComparer<Edition>
    {
        public int Compare(Edition x, Edition y)
        {
            if (x.Type == y.Type)
                return x.Name.CompareTo(y.Name);
            return x.Type.CompareTo(y.Type);
        }
    }
}