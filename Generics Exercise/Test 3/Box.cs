﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Test_3
{
   public class Box <T>
    {
        private List<T> boxCollection;

        public Box()
        {
            this.boxCollection = new List<T>();
        }

        public void AddToBox(T item)
        {
            this.boxCollection.Add(item);
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
