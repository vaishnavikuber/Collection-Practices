using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CollectionPractices
{
    internal class NonGenericCollection
    {
        public static void ArrayListFunction()
        {
            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add("vaishnavi");
            al.Add('c');
            al.Add(29.67);
            al.Add(DateTime.Now);

            foreach(var element in al)
            {
                Console.WriteLine(element);
            }
        }

        public static void HashTableFunction()
        {
            Hashtable ht = new Hashtable();
            ht.Add("a","Abhiman");
            ht.Add(12, "Hamsa");
            ht.Add(10.5, 890);
            ht.Add('s', "shri");

            foreach(DictionaryEntry element in ht)
            {
                Console.WriteLine(element.Key+"    "+element.Value);
            }
        }


    }
}
