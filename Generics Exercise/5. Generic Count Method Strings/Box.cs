using System;
using System.Collections.Generic;
using System.Text;

namespace _5._Generic_Count_Method_Strings
{
    public class Box<T> where T : IComparable
    {
        private List<T> boxCollection;
        public int GreaterCount { get;private set; }
        public Box()
        {
            this.boxCollection = new List<T>();
        }

        public void AddToBox(T item)
        {
            this.boxCollection.Add(item);
        }

        public void Compare(T item)
        {
            foreach (var currentItem in this.boxCollection)
            {
               
                if (currentItem.CompareTo(item)==1)
                {
                    GreaterCount++;
                }
            }

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var text in this.boxCollection)
            {
                sb.AppendLine($"{text.GetType().FullName} {text}");
            }


            return sb.ToString();
        }

        public void Swap(int x, int y)
        {
            T tempValue = this.boxCollection[x];
            this.boxCollection[x] = this.boxCollection[y];
            this.boxCollection[y] = tempValue;


        }
    }
}
