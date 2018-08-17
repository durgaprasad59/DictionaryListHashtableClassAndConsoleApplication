using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryListHashtableClassAndConsoleApplication
{
    class MyHashTable
    {
        static Hashtable hashtableclass = new Hashtable();

        public static void Addhashtable(int key, string value)
        {
            hashtableclass.Add(key, value);
        }

        public static void Removehashtable(int key, string value)
        {
            hashtableclass.Remove(key);
        }

        public static void Updatehashtable(int key, string value)
        {
            hashtableclass[key] = value;
        }

        public static int Counthashtable()
        {
            return hashtableclass.Count;
        }
    }
}
