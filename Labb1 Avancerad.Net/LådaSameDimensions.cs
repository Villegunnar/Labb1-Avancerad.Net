using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Labb1_Avancerad.Net
{
    public class LådaSameDimensions : EqualityComparer<Låda>
    {

        public override bool Equals([AllowNull] Låda x, [AllowNull] Låda y)
        {
            if (x.höjd == y.höjd && x.längd == y.längd
                    && x.bredd == y.bredd)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode([DisallowNull] Låda obj)
        {
            int hCode = obj.höjd ^ obj.längd ^ obj.bredd;
            return obj.GetHashCode();
        }
    }
}