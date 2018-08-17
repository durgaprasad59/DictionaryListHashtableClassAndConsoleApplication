using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryListHashtableClassAndConsoleApplication
{
    class MyDictionary
    {
        static IDictionary<int, string> dictionaryclass = new Dictionary<int, string>();

        public static void Adddictionary(int key, string value)
        {
            dictionaryclass.Add(key, value);            
        }

        public static void Removedictionary(int key)
        {
            dictionaryclass.Remove(key);
        }

        public static void Updatedictionary(int key, string oldvalue, string newvalue)
        {
            dictionaryclass[key].Replace(oldvalue, newvalue);
        }

        public static int Countdictionary()
        {
            return dictionaryclass.Count();
        }
        
    }
}
