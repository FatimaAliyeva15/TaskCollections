
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Models
{
    internal class CustomList<T>
    {
        T[] _values;

        private int _capacity;
        public int Capacity 
        {
            get {  return _capacity; }
            
            private set {  _capacity = value; }
        }

        private int _count;
        public int Count { get { return _count; } }

        public T this[int index]
        {
            get { return _values[index]; }
        }

        public CustomList(int capacity = 4)
        {
            _values = new T[capacity];
            _count = 0;
            _capacity = capacity;
        }

        public void Add(T value)
        {
            if(Capacity == Count)
            {
                Capacity *= 2;  
                Array.Resize(ref _values, Capacity);
                
            }
            _values[Count] = value;
            _count++;
        }

        public void Find(T item)
        {
            bool found = false;
            
            for (int i = 0; i < Count; i++)
            {
                if (_values[i].Equals(item))
                {
                    found = true;
                    Console.WriteLine(_values[i]);
                }
            }
            if(!found)
            {
                Console.WriteLine($"{item} list'de yoxdur");
            }
        }
        
        public T[] FindAll(Predicate<T> predicate)
        {
            T[] newValues = new T[Count];
            int newCount = 0;
            for (int i = 0;i < Count; i++)
            {
                if(predicate(_values[i]))
                {
                    newValues[newCount] = _values[i];
                    newCount++;
                }

            }
            Array.Resize(ref newValues, newCount);
            return newValues;
        }

        public void Remove(T item)
        {
            bool check = false;

            T[] newArray = new T[Count];
            int newArrayCount = 0;

            for(int i = 0;i < Count; i++)
            {
                if (!(_values[i].Equals(item)))
                {
                    newArray[newArrayCount] = _values[i];
                    newArrayCount++;
                }
                else
                {
                    check = true;
                }
            }
            if (!check)
            {
                Console.WriteLine($"{item} list'de yoxdur");
            }

            Array.Resize(ref newArray, newArrayCount);
            _values = newArray;
        }

        public bool Contains(T item)
        {
            bool check = false;
            for(int i = 0; i < Count; i++)
            {
                if (_values[i].Equals(item))
                {
                    check = true;
                }
            }
            return check;

        }

        public void Clear()
        {
            _values = new T[_capacity]; 
            _count = 0;
        }
        
        public  void RemoveAll(Predicate<T> predicate)
        {
            T[] newArray = new T[_capacity];
            int newArrayCount = 0;
            for(int i =0;i< _count; i++)
            {
                if (!predicate(_values[i]))
                {
                    newArray[newArrayCount] = _values[i];
                    newArrayCount++;
                }
                
            }
            Array.Resize(ref newArray, newArrayCount);
            _values = newArray;
            _count = newArrayCount;
            
        }
    }
       
}
