using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionPractices
{
    internal class GenericCollections
    {
        public static void ListFunction()
        {
            List<string> list = new List<string>();
            list.Add("Apple");
            list.Add("Net");
            list.Add("Cuop");
            list.Add("Elephant");

            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
        }

        public static void DictionaryFunction()
        {

        }

    }
}
