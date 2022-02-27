using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace Labb1_Avancerad.Net
{
    public class LådaCollection : ICollection<Låda>
    {

        public IEnumerator<Låda> GetEnumerator()
        {
            return innerCol.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        
        private List<Låda> innerCol;

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public LådaCollection()
        {
            innerCol = new List<Låda>();
        }

        
        public Låda this[int index]
        {
            get { return (Låda)innerCol[index]; }
            set { innerCol[index] = value; }
        }


        public bool Contains(Låda item)
        {
            bool found = false;

            foreach (Låda bx in innerCol)
            {

                if (bx.Equals(item))
                {
                    found = true;
                }
            }
            return found;
        }


        public bool Contains(Låda item, EqualityComparer<Låda> comp)
        {
            bool found = false;

            foreach (Låda bx in innerCol)
            {
                if (comp.Equals(bx, item))
                {
                    found = true;
                }
            }

            return found;
        }

        public void Add(Låda item)
        {
            if (Contains(item))
            {
                Console.WriteLine("Box with the same dimensions already exists in the list");
            }
            else
            {
                innerCol.Add(item);
                Console.WriteLine("Added item to the list");
            }
            
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Låda[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Låda item)
        {
            bool result = false;

            for (int i = 0; i < innerCol.Count; i++)
            {

                Låda låda = (Låda)innerCol[i];

                if (new LådaSameDimensions().Equals(låda, item))
                {
                    innerCol.RemoveAt(i);
                    result = true;
                    break;
                }
            }
            return result;
        }

    }
}
