using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class CustomList<T>
    {
        T[] Values;
        public int Capacity { get; set; }

        public int Count { get; set; }

        public int Indexer { get; set; }

        public CustomList()
        {
            Values = Array.Empty<T>();
        }

        public void Add(T value)
        {
            Array.Resize(ref Values, Values.Length + 1);
            Values[^1] = value;
            Count++;
        }


    }
}
