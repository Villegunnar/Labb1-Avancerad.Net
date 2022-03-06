using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System;
namespace Labb1_Avancerad.Net
{
    public class LådaSameDimensions : EqualityComparer<Låda>
    {

        // Definierar två rutor som lika om de har samma dimensioner
        public override bool Equals(Låda lådaEtt, Låda lådaTvå)
        {
            if (lådaEtt.höjd == lådaTvå.höjd && lådaEtt.längd == lådaTvå.längd
                    && lådaEtt.bredd == lådaTvå.bredd)
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
            Console.WriteLine($"Hashcode: {hCode.GetHashCode()}");
            return hCode.GetHashCode();
        }
    }
}