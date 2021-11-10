using System;
using System.Collections;
using System.Text;

namespace MyCollections
{

    class MySortedList
    {
        public SortedList st;
        const int CAPACITY = 100;


        public MySortedList()
        {
            st = new SortedList(CAPACITY);
        }

        public MySortedList(int n)
        {
            if (n > CAPACITY) n = CAPACITY;
            st = new SortedList(n);
        }

        public bool Add(object key, object value) {
            if (st.ContainsKey(key)) return false;
            st.Add(key, value);
            return true;
        }

        public void PrintKeysAndValues()
        {
            Console.WriteLine("        -KEY-   -VALUE-");
            for (int i = 0; i < st.Count; i++)
            {
                Console.WriteLine("        {0,-6}: {1}", st.GetKey(i), st.GetByIndex(i));
            }
            Console.WriteLine();
        }

    }
    }
