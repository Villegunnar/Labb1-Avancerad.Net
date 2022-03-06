using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace Labb1_Avancerad.Net
{
    public class LådaCollection : ICollection<Låda>
    {

     
        // En enumerator som kan användas för att iterera igenom din collection
        public IEnumerator<Låda> GetEnumerator()
        {
            return new LådaEnumerator(this);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new LådaEnumerator(this);
        }


        // innercol är din collection för att lagra object
        private List<Låda> innerCol;
        public LådaCollection()
        {
            innerCol = new List<Låda>();
        }


        //Lägger till ett index till din collection
        public Låda this[int index]
        {
            get { return (Låda)innerCol[index]; }
            set { innerCol[index] = value; }
        }


        // Avgör om ett object är i din collection genom att använda LådaSameDimensions equality comparer.
        public bool Contains(Låda låda)
        {
            bool found = false;

            foreach (Låda L in innerCol)
            {
                
                if (L.Equals(låda))
                {
                    found = true;
                }
            }
            return found;
        }

        // Avgör om ett object är i din collection genom att använda en specifik equality comparer.
        public bool Contains(Låda låda, EqualityComparer<Låda> comp)
        {
            bool found = false;

            foreach (Låda L in innerCol)
            {
                if (comp.Equals(L, låda))
                {
                    found = true;
                }
            }

            return found;
        }


        //Lägger till ett object sålänge som den inte redan finns i din collection genom att kalla på Contains metoden.
        public void Add(Låda låda)
        {
            if (!Contains(låda))
            {
                innerCol.Add(låda);
                Console.WriteLine("Lade till lådan i listan");
            }
            else
            {
                Console.WriteLine($"En låda med dimensionerna höjd:{låda.höjd} längd:{låda.längd} bredd:{låda.bredd} finns redan i listan");
            }

        }

        // Tar bort alla elementen från din collection 
        public void Clear()
        {
            innerCol.Clear();
        }
        public int Count 
        { 
            get 
            { 
                return innerCol.Count; 
            } 
        }

        // Kopierar alla elementen från collection till en array av låda vid ett specifikt index
        public void CopyTo(Låda[] array, int arrayIndex)
        {
            if (array == null)
            {
                throw new ArgumentException("The array cannot be null.");

            }
            if (arrayIndex < 0)
            {
                throw new ArgumentException("The starting array index cannot be negative.");
            }
            if (Count > array.Length - arrayIndex +1)
            {
                throw new ArgumentException("The destination array has fewer elements than the collection.");
            }

            for (int i = 0; i < innerCol.Count; i++)
            {
                array[i + arrayIndex] = innerCol[i];
            }
        }



        // Itererar igenom din collection för att hitta lådan som skall tas bort
        public bool Remove(Låda item)
        {
            bool result = false;

            for (int i = 0; i < innerCol.Count; i++)
            {

                Låda curLåda = (Låda)innerCol[i];

                if (new LådaSameDimensions().Equals(curLåda, item))
                {
                    innerCol.RemoveAt(i);

                    Console.WriteLine($"Objektet med dimensionerna  höjd:{item.höjd}  längd:{ item.längd}  bredd:{ item.bredd} { item.GetHashCode()} togs bort!");
                    result = true;
                    break;
                }
            }
            return result;
        }

        public bool IsReadOnly 
        { 
            get 
            { 
                return false; 
            } 
        }
    }
}
