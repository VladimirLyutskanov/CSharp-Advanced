﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _7._Tuple
{
    public class Tuple<T, V>
    {
        private T item1;
        private V item2;
        public Tuple(T item1,V item2)
        {
            this.item1 = item1;
            this.item2 = item2;
        }
        public string GetInfo()
        {
            return $"{this.item1} -> {this.item2}";
        }
    }

}
