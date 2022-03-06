
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;


namespace Labb1_Avancerad.Net
{
    public class LådaSameVol : EqualityComparer<Låda>
    {
        // Definierar två rutor som lika om de har samma volym.
        public override bool Equals([AllowNull] Låda lådaEtt, [AllowNull] Låda lådaTvå)
        {
            if ((lådaEtt.höjd * lådaEtt.bredd * lådaEtt.längd) == (lådaTvå.höjd * lådaTvå.bredd * lådaTvå.längd))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode([DisallowNull] Låda låda)
        {
            int hCode = låda.höjd ^ låda.längd ^ låda.bredd;       
            return hCode.GetHashCode();
        }


    }
}
