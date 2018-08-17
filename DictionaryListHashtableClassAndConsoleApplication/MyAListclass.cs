using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryListHashtableClassAndConsoleApplication
{
    class MyAListclass
    {
        static ArrayList Arraylistclass = new ArrayList();

        public static void AddArraylist(int value)
        {
            Arraylistclass.Add(value);
        }

        public static void RemoveArraylist(int value)
        {
            Arraylistclass.Remove(value);
        }

        public static void UpdateArraylist(int value, int position)
        {
            Arraylistclass.Insert(position, value);
        }

        public static int CountArraylist(int value)
        {
            return Arraylistclass.Count;
        }
    }
}
