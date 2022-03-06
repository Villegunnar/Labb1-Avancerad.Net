using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Labb1_Avancerad.Net
{


    public class LådaEnumerator : IEnumerator<Låda>
    {
        private LådaCollection _låda;
        private int currentIndex;
        private Låda currentLåda;


        public LådaEnumerator(LådaCollection låda)
        {
            this._låda = låda;
            this.currentIndex = -1;
            this.currentLåda = default(Låda);
        }

        public Låda Current { get { return currentLåda; } }

        object IEnumerator.Current { get { return Current; } }

        public int Count { get { return _låda.Count; } }


        public bool MoveNext()
        {
            
            //Undviker att gå till ett högre index än vad din Collection innehåller.
            if (++currentIndex >= _låda.Count)
            {
                return false;
            }
            else
            {

            // Sätter aktuell låda till nästa objekt i samlingen.
                currentLåda = _låda[currentIndex];
            }
            return true;
        }
        public void Reset()
        {
            currentIndex = -1;
        }
        public void Dispose()
        {

        }
    }
}
